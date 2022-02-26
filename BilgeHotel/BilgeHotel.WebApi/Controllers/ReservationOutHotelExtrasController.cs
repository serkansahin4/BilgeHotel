using BilgeHotel.Business.Abstract;
using BilgeHotel.WebApi.Models.ViewModels.ComplexTypeVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationOutHotelExtrasController : ControllerBase
    {
        private readonly IReservationOutHotelExtraService _hotelExtra;
        public ReservationOutHotelExtrasController(IReservationOutHotelExtraService hotelExtra)
        {
            _hotelExtra = hotelExtra;
        }

        [HttpGet("{reservationId}")]
        public IActionResult Get(Guid reservationId)
        {
           List<ReservationOutHotelExtraGetVM> getVM= _hotelExtra.GetAll(reservationId).Select(x=>new ReservationOutHotelExtraGetVM { HotelExtraId=x.HotelExtraId, HotelExtraName=x.HotelExtra.ExtraName, Quantity=x.Quantity, ReservationId=x.ReservationId  }).ToList();
            return Ok(getVM);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ReservationOutHotelExtraPostVM postVM)
        {
            bool kontrol = await _hotelExtra.AddAsync(postVM.ReservationId, postVM.HotelExtraId, postVM.Quantity);
            if (kontrol)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
