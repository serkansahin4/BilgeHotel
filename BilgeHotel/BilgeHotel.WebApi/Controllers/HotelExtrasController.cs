using BilgeHotel.Business.Abstract;
using BilgeHotel.Entities.Concrete;
using BilgeHotel.WebApi.Models.ViewModels;
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
    public class HotelExtrasController : ControllerBase
    {
        private readonly IHotelExtraService _hotelExtraService;
        public HotelExtrasController(IHotelExtraService service)
        {
            _hotelExtraService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            HotelExtra hotelExtra = _hotelExtraService.GetById(id);
            if (hotelExtra != null)
            {
                HotelExtraVM hotelExtraVM = new HotelExtraVM();
                hotelExtraVM.Id = hotelExtra.Id;
                hotelExtraVM.ExtraName = hotelExtra.ExtraName;
                hotelExtraVM.Price = hotelExtra.Price;
                return Ok(hotelExtraVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<HotelExtraVM> hotelExtras = _hotelExtraService.GetAll().Select(x => new HotelExtraVM { Id = x.Id, ExtraName = x.ExtraName, Price=x.Price }).ToList();
            return Ok(hotelExtras);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] HotelExtraVM hotelExtraVM)
        {
            bool kontrol = await _hotelExtraService.AddAsync(
                new HotelExtra
                {
                    ExtraName = hotelExtraVM.ExtraName,
                    Price=hotelExtraVM.Price
                });
            if (kontrol == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] HotelExtraVM hotelExtraVM)
        {
            HotelExtra hotelExtra = _hotelExtraService.GetById(hotelExtraVM.Id);
            if (hotelExtra != null)
            {
                hotelExtra.ExtraName = hotelExtraVM.ExtraName;
                hotelExtra.Price = hotelExtraVM.Price;
                bool kontrol = await _hotelExtraService.UpdateAsync(hotelExtra);
                if (kontrol == true)
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool kontrol = await _hotelExtraService.DeleteByIdAsync(id);
            if (kontrol == true)
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
