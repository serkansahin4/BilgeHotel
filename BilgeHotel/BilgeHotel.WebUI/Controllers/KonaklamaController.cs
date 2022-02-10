using BilgeHotel.Business.Abstract;
using BilgeHotel.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebUI.Controllers
{
    public class KonaklamaController : Controller
    {
        private readonly IRoomTypeService _roomTypeService;
        public KonaklamaController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }
        public IActionResult Index()
        {
            List<RoomType> roomTypes = _roomTypeService.GetAll();
            if (roomTypes.Count>0)
            {
                return View(roomTypes.FirstOrDefault());
            }
            return View();
        }
        [HttpGet]
        public IActionResult Ileri(int? id)
        {
            List<RoomType> roomTypes = _roomTypeService.GetAll();
            RoomType roomType = roomTypes.SingleOrDefault(x => x.Id == id);
            if (roomType!=null)
            {
                int dizidekiSirasi = roomTypes.IndexOf(roomType);
                if (dizidekiSirasi<roomTypes.Count-1)
                {
                    return View("Index", roomTypes[dizidekiSirasi + 1]);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Geri(int? id)
        {
            List<RoomType> roomTypes = _roomTypeService.GetAll();
            RoomType roomType = roomTypes.SingleOrDefault(x => x.Id == id);

            if (roomType != null)
            {
                int dizidekiSirasi = roomTypes.IndexOf(roomType);
                if (dizidekiSirasi-1 > 0)
                {
                    return View("Index", roomTypes[dizidekiSirasi -1]);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
