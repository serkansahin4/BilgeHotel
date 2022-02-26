using BilgeHotel.Business.Abstract;
using BilgeHotel.CacheReservation;
using BilgeHotel.Core.MyTools.Abstract;
using BilgeHotel.Core.MyTools.Concrete;
using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using BilgeHotel.ViewModels.ViewModels;
using BilgeHotel.WebUI.APIHelper;
using BilgeHotel.WebUI.Models;
using BilgeHotel.WebUI.Models.ViewModels;
using BilgeHotel.WebUI.Models.ViewModels.APIPostVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.WebUI.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IRoomService _roomService;
        private readonly IRoomTypeService _roomTypeService;
        private readonly IReservationDetailService _reservationDetailService;
        private readonly IDateManagementExtension _dateManagementExtension;
        private readonly IPackageService _packageService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICustomerService _customerService;
        private BankAPI _bankApi = new BankAPI();
        private readonly IReservationService _reservationService;
        private readonly ICardService _cardService;
        public ReservationController(ICardService cardService,IReservationService reservationService, ICustomerService customerService, IRoomService roomService, IRoomTypeService roomTypeService, IReservationDetailService reservationDetailService, IDateManagementExtension dateManagementExtension, IPackageService packageService, IHttpContextAccessor httpContextAccessor)
        {
            _roomService = roomService;
            _roomTypeService = roomTypeService;
            _reservationDetailService = reservationDetailService;
            _dateManagementExtension = dateManagementExtension;
            _packageService = packageService;
            _httpContextAccessor = httpContextAccessor;
            _customerService = customerService;
            _reservationService = reservationService;
            _cardService = cardService;
        }
        public IActionResult Index()
        {
            return View(_roomTypeService.GetAll());
        }

        public IActionResult _ReadyRoomsPartial(int id)
        {
            RoomType roomType = _roomTypeService.Get(id);
            if (roomType != null)
            {
                return View(_roomService.GetAllReady(roomType.Id));
            }

            return View("Index");
        }

        [HttpGet]
        public IActionResult _ReservationCreatePartial(int id)
        {
            List<DateEntity> dates = _reservationDetailService.GetAll(id).Select(x => new DateEntity
            {
                Baslangic = x.CheckInDate,
                Bitis = x.CheckOutDate
            }).ToList();

            List<DateTime> dateTimes = _dateManagementExtension.BaslangicTarihleri(dates);

            TempData["PaketTipi"] = _packageService.GetAll();
            TempData["ReservationGetir"] = _dateManagementExtension.BaslangicTarihleri(dates);
            ViewData["RoomId"] = id;
            return View();
        }

        [HttpGet]
        public string GetOutDate(DateFormat dates, int id)
        {
            DateTime date = new DateTime(dates.Year, dates.Month, dates.Day, dates.Hour, dates.Minute, dates.Second);
            List<DateEntity> musaitZaman = _reservationDetailService.GetAll(id).ToList().Select(x => new DateEntity
            {
                Baslangic = x.CheckInDate,
                Bitis = x.CheckOutDate
            }).ToList();
            List<DateTime> dateTimes = _dateManagementExtension.BaslangicTarihleri(musaitZaman);
            //List<DateTime> dateTimes = JsonConvert.DeserializeObject<List<DateTime>>(TempData["ReservationDates"] as string);

            return JsonConvert.SerializeObject(_dateManagementExtension.BitisTarihleri(dateTimes, date));
        }




        [HttpPost]
        public IActionResult _ReservationCreatePartial(ReservationCreateVM reservationCreateVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Put("ReservationDetail", reservationCreateVM);
            return RedirectToAction("Pay");
        }

        public IActionResult Pay()
        {
            ReservationCreateVM reservations = TempData.Get<ReservationCreateVM>("ReservationDetail");
            double discount = _reservationDetailService.Discount(reservations.CheckInDate, reservations.CreatedDate, reservations.PackageId);
            double discountedPrice = _reservationDetailService.DiscountedPrice(reservations.CheckInDate, reservations.CheckOutDate, discount, _roomService.PriceGetById(reservations.RoomId), _packageService.PriceGetById(reservations.PackageId));
            TempData.Put("ReservationDetail", reservations);
            ViewBag.Discount = discount;
            ViewBag.DiscountedPrice = discountedPrice;

            List<CardTypeVM> cardType = new List<CardTypeVM>
            {
            new CardTypeVM { CardTypeId=1, CardName="Ziraat Bankası" },
            new CardTypeVM{ CardTypeId=2, CardName="Finans Bankası" }
            };

            ViewBag.sss = new SelectList(cardType, "CardTypeId", "CardName");

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Pay(PayVM payVM)
        {
            //1 Ziraat, 2 Finans
            List<CardTypeVM> cardType = new List<CardTypeVM>
            {
            new CardTypeVM { CardTypeId=1, CardName="Ziraat Bankası" },
            new CardTypeVM{ CardTypeId=2, CardName="Finans Bankası" }
            };
            if (ModelState.IsValid)
            {

                ReservationCreateVM reservations = TempData.Get<ReservationCreateVM>("ReservationDetail");
                double discount = _reservationDetailService.Discount(reservations.CheckInDate, reservations.CreatedDate, reservations.PackageId);
                double discountedPrice = _reservationDetailService.DiscountedPrice(reservations.CheckInDate, reservations.CheckOutDate, discount, _roomService.PriceGetById(reservations.RoomId), _packageService.PriceGetById(reservations.PackageId));

                PayAPIVM payAPIVM = new PayAPIVM();
                payAPIVM.CardNo = payVM.CardNumber;
                payAPIVM.CV2 = payVM.CV2;
                payAPIVM.EndDate = payVM.EndDate;
                payAPIVM.Amount = discountedPrice;

                CardInformationVM card = new CardInformationVM();
                card.CardNumber = payVM.CardNumber;
                card.CardType = payVM.CardTypeId.ToString();
                card.CV2 = payVM.CV2;
                card.EndDate = payVM.EndDate;

                var json = JsonConvert.SerializeObject(payAPIVM);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                TempData["cardTypeId"] = payVM.CardTypeId.ToString();
                switch (payVM.CardTypeId)
                {
                    case 1:
                        HttpResponseMessage ziraatPost = await _bankApi.Inıtıal().PostAsync("api/Ziraats/PayPost", data);

                        if (ziraatPost.StatusCode == HttpStatusCode.OK)
                        {
                            TempData.Put("CardInformation", card);
                            return RedirectToAction("Confirmation");
                        }
                        else
                        {

                            ViewBag.sss = new SelectList(cardType.ToList(), "CardTypeId", "CardName");
                            TempData["Pay"] = "Bilgiler Eşleşmiyor.";
                            return View("Pay");
                        }
                    case 2:
                        HttpResponseMessage finansPost = await _bankApi.Inıtıal().PostAsync("api/Ziraats/PayPost", data);

                        if (finansPost.StatusCode == HttpStatusCode.OK)
                        {
                            TempData.Put("CardInformation", card);
                            return RedirectToAction("Confirmation");
                        }
                        else
                        {
                            ViewBag.sss = new SelectList(cardType.ToList(), "CardTypeId", "CardName");
                            TempData["Pay"] = "Bilgiler Eşleşmiyor.";
                            return View("Pay");
                        }
                }

                ViewBag.sss = new SelectList(cardType.ToList(), "CardTypeId", "CardName");
                return View("Pay");

            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult Confirmation()
        {
            ReservationCreateVM reservations = TempData.Get<ReservationCreateVM>("ReservationDetail");
            TempData.Put("ReservationDetail", reservations);
            //ÖDEME YAPMADAN ÖNCE HALA REZERVASYON YAPILMIŞMI YAPILMAMIŞMI KONTROL ET.
            ReservationCacheExtension extension = new ReservationCacheExtension();
            Guid cacheControl = Guid.NewGuid();
            TempData["CacheControl"] = cacheControl;
            bool kontrol = extension.CacheInAdd(new ReservationCacheDTO { CheckInDate = reservations.CheckInDate, CheckOutDate = reservations.CheckOutDate, RoomId = reservations.RoomId, ReservationIdentity = cacheControl });
            //kontrol True ise Ekleme Yapılacak.
            //kontrol False ise Böyle bir rezervasyon mevcuttur.
            if (kontrol == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Confirmation(ConfirmationAPIVM confirmation)
        {
            ReservationCreateVM reservations = TempData.Get<ReservationCreateVM>("ReservationDetail");
            double discount = _reservationDetailService.Discount(reservations.CheckInDate, reservations.CreatedDate, reservations.PackageId);
            double discountedPrice = _reservationDetailService.DiscountedPrice(reservations.CheckInDate, reservations.CheckOutDate, discount, _roomService.PriceGetById(reservations.RoomId), _packageService.PriceGetById(reservations.PackageId));

            int cardTypeId = Convert.ToInt32(TempData["cardTypeId"]); //Seçili Kart Bulma.
            var json = JsonConvert.SerializeObject(confirmation.VerificationCode);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response=null;
            switch (cardTypeId)
            {
                case 1:
                    response = await _bankApi.Inıtıal().PostAsync("api/Ziraats/GuidPost", data);
                    break;
                case 2:
                    response = await _bankApi.Inıtıal().PostAsync("api/Finans/GuidPost", data);
                    break;
            }
            

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Guid reservationId = Guid.NewGuid();
                //MÜŞTERİ KAYDET.
                await _customerService.Add(reservations.Customer);
                //REZERVATİON KAYDET
                await _reservationService.Add(new Reservation { CustomerId=reservations.Customer.Id, Id= reservationId });
                //Kart Bilgilerini Kaydet.
                #region KartOluştur

                CardInformationVM card = TempData.Get<CardInformationVM>("CardInformation");
                string cardType = "";
                switch (card.CardType)
                {
                    case "1":
                        cardType = "Ziraat Bankası AŞ.";
                        break;
                    case "2":
                        cardType = "Finans Bankası AŞ.";
                        break;
                }
                Guid cardId = Guid.NewGuid();
                
                #endregion
                await _cardService.Add(new Card { CardNumber = card.CardNumber, EndDate = card.EndDate, Cv2 = card.CV2, CardType = cardType,Id= cardId });
                
                //KAYDEDİLEN REZERVATİONUN IDSI İLE REZERVATİON DETAİL OLUŞTUR.
                await _reservationDetailService.Add(new ReservationDetail { ReservationId = reservationId, CheckInDate =reservations.CheckInDate, CheckOutDate=reservations.CheckOutDate, CreatedDate=reservations.CreatedDate, PackageId=reservations.PackageId, RoomId=reservations.RoomId, Discount=discount, DiscountedPrice= discountedPrice, CardId= cardId });
                ReservationCacheExtension extension = new ReservationCacheExtension();
                //extension.CacheInRemove((Guid)TempData["CacheControl"]); CACHEYİ 6 AYDA BİR TEMİZLEMEK GEREKİYOR.
                return RedirectToAction("ReservationComplete");
            }
            else
            {
                TempData["Verification"] = "Girilen Kod Doğru Değil.";
                return View();
            }

        }

        [HttpGet]
        public IActionResult ReservationComplete()
        {
            string completeMessage = "Ödeme Gerçekleşti. Rezervasyon Oluşturuldu.";
            return View("ReservationComplete", completeMessage);
        }

    }
}
