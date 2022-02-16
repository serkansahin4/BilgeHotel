using BilgeHotel.Business.Abstract;
using BilgeHotel.Core.MyTools.Abstract;
using BilgeHotel.Core.MyTools.Concrete;
using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using BilgeHotel.ViewModels.ViewModels;
using BilgeHotel.WebUI.Models;
using BilgeHotel.WebUI.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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
            TempData["ReservationDates"] = JsonConvert.SerializeObject(_dateManagementExtension.BaslangicTarihleri(dates));
            TempData["ReservationGetir"] = _dateManagementExtension.BaslangicTarihleri(dates);
            ViewData["RoomId"] = id;
            return View();
        }

        [HttpGet]
        public string GetOutDate(DateFormat dates)
        {
            DateTime date = new DateTime(dates.Year,dates.Month,dates.Day,dates.Hour,dates.Minute,dates.Second);
            List<DateTime> dateTimes =JsonConvert.DeserializeObject<List<DateTime>>(TempData["ReservationDates"]as string);
            TempData["ReservationDates"] = null;
            return JsonConvert.SerializeObject(_dateManagementExtension.BitisTarihleri(dateTimes, date));
        }




        [HttpPost]
        public IActionResult _ReservationCreatePartial(ReservationCreateVM reservationCreateVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            CookieOptions cookieOptions = new CookieOptions();

            TempData.Put("ReservationDetail", reservationCreateVM);
            return RedirectToAction("Pay");
        }

        public IActionResult Pay()
        {
            ReservationCreateVM reservations = TempData.Get<ReservationCreateVM>("ReservationDetail");
            return View();
        }

        //Burda Kaldım 16.02.2022
        [HttpPost]
        public IActionResult Pay(PayVM payVM)
        {
            return View();
        }
    }
}
