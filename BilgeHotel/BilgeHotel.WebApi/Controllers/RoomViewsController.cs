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
    public class RoomViewsController : ControllerBase
    {
        private readonly IRoomViewService _roomViewService;
        public RoomViewsController(IRoomViewService service)
        {
            _roomViewService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RoomView roomView = _roomViewService.GetById(id);
            if (roomView != null)
            {
                RoomViewVM roomViewVM = new RoomViewVM();
                roomViewVM.Id = roomView.Id;
                roomViewVM.ViewName = roomView.ViewName;
                return Ok(roomViewVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<RoomViewVM> roomViews = _roomViewService.GetAll().Select(x => new RoomViewVM { Id = x.Id, ViewName = x.ViewName }).ToList();
            return Ok(roomViews);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoomViewVM roomViewVM)
        {
            bool kontrol = await _roomViewService.AddAsync(
                new RoomView
                {
                    ViewName = roomViewVM.ViewName
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
        public async Task<IActionResult> Put([FromBody] RoomViewVM roomViewVM)
        {
            RoomView roomView = _roomViewService.GetById(roomViewVM.Id);
            if (roomView != null)
            {
                roomView.ViewName = roomViewVM.ViewName;
                bool kontrol = await _roomViewService.UpdateAsync(roomView);
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
            bool kontrol = await _roomViewService.DeleteByIdAsync(id);
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
