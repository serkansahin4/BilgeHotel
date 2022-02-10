using BilgeHotel.Business.Abstract;
using BilgeHotel.Entities.Concrete;
using BilgeHotel.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
            public ReservationController(IRoomService roomService,IRoomTypeService roomTypeService)
        {
            _roomService = roomService;
            _roomTypeService = roomTypeService;
        }
        public IActionResult Index()
        {
            //ReservationIndexVM reservationIndexVM = new ReservationIndexVM();
            //reservationIndexVM.RoomTypes = ;
            return View(_roomTypeService.GetAll());
        }

        public IActionResult _ReadyRoomsPartial(int id)
        {
            RoomType roomType = _roomTypeService.Get(id);
            if (roomType!=null)
            {
                return View(_roomService.GetAll().Where(x => x.RoomTypeId == roomType.Id).ToList());
            }
            return View("Index");
        }

        public IActionResult Create(Customer customer,Room room, Reservation reservation) //Burda takıldık. rezervasyon oluşturacağız.
        {

        }
    }
}
