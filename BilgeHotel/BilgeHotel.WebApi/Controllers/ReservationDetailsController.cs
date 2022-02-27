using BilgeHotel.Business.Abstract;
using BilgeHotel.WebApi.Models.DTO;
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
    public class ReservationDetailsController : ControllerBase
    {
        private readonly IReservationDetailService _detailService;
        public ReservationDetailsController(IReservationDetailService detailService)
        {
            _detailService = detailService;
        }

        [HttpGet("CheckInDate/{roomId}")]
        public IActionResult CheckInDate(int roomId)
        {
          return Ok( _detailService.CheckInDates(roomId));
        }


        [HttpPost]
        [Route("[action]")]
        public IActionResult CheckOutDate([FromBody]ReservationDetailCheckOutDTO outDTO)
        {
            return Ok(_detailService.CheckOutDates(outDTO.checkInDates, outDTO.checkInDate));
        }

        [HttpGet("GetRoomId/{roomId}")]

        public IActionResult GetRoomId(int roomId)
        {
            return Ok(_detailService.GetAll(roomId));
        }

        [HttpGet("GetReservationId/{reservationId}")]
        public IActionResult GetReservationId(Guid reservationId)
        {
            return Ok(_detailService.Get(reservationId));
        }

    }
}
