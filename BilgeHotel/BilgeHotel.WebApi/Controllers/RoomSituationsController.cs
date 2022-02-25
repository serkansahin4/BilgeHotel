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
    public class RoomSituationsController : ControllerBase
    {
        private readonly IRoomSituationService _roomSituationService;
        public RoomSituationsController(IRoomSituationService service)
        {
            _roomSituationService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RoomSituation roomSituation = _roomSituationService.GetById(id);
            if (roomSituation != null)
            {
                RoomSituationVM roomSituationVM = new RoomSituationVM();
                roomSituationVM.Id = roomSituation.Id;
                roomSituationVM.StatusName = roomSituation.StatusName;
                return Ok(roomSituationVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<RoomSituationVM> roomSituations = _roomSituationService.GetAll().Select(x => new RoomSituationVM { Id = x.Id, StatusName = x.StatusName }).ToList();
            return Ok(roomSituations);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoomSituationVM roomSituationVM)
        {
            bool kontrol = await _roomSituationService.AddAsync(
                new RoomSituation
                {
                    StatusName = roomSituationVM.StatusName
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
        public async Task<IActionResult> Put([FromBody] RoomSituationVM roomSituationVM)
        {
            RoomSituation roomSituation = _roomSituationService.GetById(roomSituationVM.Id);
            if (roomSituation != null)
            {
                roomSituation.StatusName = roomSituationVM.StatusName;
                bool kontrol = await _roomSituationService.UpdateByAsync(roomSituation);
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
            bool kontrol = await _roomSituationService.DeleteByIdAsync(id);
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
