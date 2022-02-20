using BilgeHotel.Business.Abstract;
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
        private BankAPI _bankApi = new BankAPI();
        public ReservationController(IRoomService roomService, IRoomTypeService roomTypeService, IReservationDetailService reservationDetailService, IDateManagementExtension dateManagementExtension, IPackageService packageService, IHttpContextAccessor httpContextAccessor)
        {
            _roomService = roomService;
            _roomTypeService = roomTypeService;
            _reservationDetailService = reservationDetailService;
            _dateManagementExtension = dateManagementExtension;
            _packageService = packageService;
            _httpContextAccessor = httpContextAccessor;

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
                return View(_roomService.GetAll().Where(x => x.RoomTypeId == roomType.Id).ToList());
            }

            return View("Index");
        }

        [HttpGet]
        public IActionResult _ReservationCreatePartial(int id)
        {

            List<DateEntity> dates = _reservationDetailService.GetAll(id).ToList().Select(x => new DateEntity
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
            //ReservationCreateVM reservations = TempData.Get<ReservationCreateVM>("ReservationDetail");

            ////double discount = _reservationDetailService.Discount(reservations.CheckInDate, reservations.CreatedDate, reservations.PackageId);
            ////double discountedPrice = _reservationDetailService.DiscountedPrice(reservations.CheckInDate, reservations.CheckOutDate, discount, _roomService.PriceGetById(reservations.RoomId), _packageService.PriceGetById(reservations.PackageId));
            ////TempData.Put("ReservationDetail", reservations);
            //ViewBag.Discount = discount;
            //ViewBag.DiscountedPrice = discountedPrice;
            List<CardTypeVM> cardType = new List<CardTypeVM>
            {
            new CardTypeVM { CardTypeId=1, CardName="Ziraat Bankası" },
            new CardTypeVM{ CardTypeId=2, CardName="Finans Bankası" }
            };
            //List<SelectListItem> listItems = cardType.ToList().Select(x=>
            //new SelectListItem { 
            //    Value=x.CardTypeId.ToString(), 
            //    Text=x.CardName }).ToList();

            ViewBag.sss = new SelectList(cardType.ToList(), "CardTypeId", "CardName");

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

                var json = JsonConvert.SerializeObject(payAPIVM);
                var data = new StringContent(json, Encoding.UTF8, "application/json");


                switch (payVM.CardTypeId)
                {
                    case 1:
                        HttpResponseMessage ziraatPost = await _bankApi.Inıtıal().PostAsync("api/Ziraats/PayPost", data);

                        if (ziraatPost.StatusCode == HttpStatusCode.OK)
                        {
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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Confirmation(ConfirmationAPIVM confirmation)
        {
            ReservationCreateVM reservations = TempData.Get<ReservationCreateVM>("ReservationDetail");
            double discount = _reservationDetailService.Discount(reservations.CheckInDate, reservations.CreatedDate, reservations.PackageId);
            double discountedPrice = _reservationDetailService.DiscountedPrice(reservations.CheckInDate, reservations.CheckOutDate, discount, _roomService.PriceGetById(reservations.RoomId), _packageService.PriceGetById(reservations.PackageId));


            //ÖDEME YAPMADAN ÖNCE HALA REZERVASYON YAPILMIŞMI YAPILMAMIŞMI KONTROL ET.

            var json = JsonConvert.SerializeObject(confirmation.VerificationCode);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _bankApi.Inıtıal().PostAsync("api/Ziraats/GuidPost", data);
            if (response.StatusCode == HttpStatusCode.OK)
            {
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
