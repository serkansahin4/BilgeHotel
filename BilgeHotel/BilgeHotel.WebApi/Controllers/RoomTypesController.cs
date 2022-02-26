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
    public class RoomTypesController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;
        public RoomTypesController(IRoomTypeService service)
        {
            _roomTypeService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RoomType roomType = _roomTypeService.Get(id);
            if (roomType != null)
            {
                RoomTypeVM roomTypeVM = new RoomTypeVM();
                roomTypeVM.Id = roomType.Id;
                roomTypeVM.RoomTypeName = roomType.RoomTypeName;
                roomTypeVM.Name = roomType.Name;
                roomTypeVM.Price = roomType.Price;
                return Ok(roomTypeVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<RoomTypeVM> roomTypes = _roomTypeService.GetAll().Select(x => new RoomTypeVM { Id = x.Id, RoomTypeName = x.RoomTypeName, Name = x.Name, Price = x.Price }).ToList();
            return Ok(roomTypes);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoomTypeVM roomTypeVM)
        {
            bool kontrol = await _roomTypeService.AddAsync(
                new RoomType
                {
                    RoomTypeName = roomTypeVM.RoomTypeName,
                    Name = roomTypeVM.Name,
                    Price = roomTypeVM.Price,
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
        public async Task<IActionResult> Put([FromBody] RoomTypeVM roomTypeVM)
        {
            RoomType roomType = _roomTypeService.Get(roomTypeVM.Id);
            if (roomType != null)
            {
                roomType.RoomTypeName = roomTypeVM.RoomTypeName;
                roomType.Name = roomTypeVM.Name;
                roomType.Price = roomTypeVM.Price;
                bool kontrol = await _roomTypeService.UpdateAsync(roomType);
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
            bool kontrol = await _roomTypeService.DeleteByIdAsync(id);
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
