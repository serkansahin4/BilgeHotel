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
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomsController(IRoomService service)
        {
            _roomService = service;
        }

        [HttpGet("PriceGetById/{roomName}")]
        public IActionResult PriceGetById(int roomName)
        {
            return Ok(_roomService.PriceGetById(roomName));
        }




        [HttpGet("GetAllReady/{roomTypeId}")]
        
        public IActionResult GetAllReady(int roomTypeId)
        {
            return Ok(_roomService.GetAllReady(roomTypeId));
        }

        [HttpGet("Get/{roomName}")]
        public IActionResult Get(int roomName)
        {
            Room room = _roomService.Get(roomName);
            if (room != null)
            {
                RoomVM roomVM = new RoomVM();
                roomVM.RoomName = room.RoomName;
                roomVM.RoomSize = room.RoomSize;
                roomVM.RoomTypeId = room.RoomTypeId;
                roomVM.RoomViewId = room.RoomViewId;
                roomVM.RoomSituationId = room.RoomSituationId;
                return Ok(roomVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<RoomVM> rooms = _roomService.GetAll().Select(x => new RoomVM { RoomName=x.RoomName,  RoomSituationId = x.RoomSituationId,  RoomSize = x.RoomSize, RoomTypeId=x.RoomTypeId, RoomViewId=x.RoomViewId }).ToList();
            return Ok(rooms);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoomVM roomVM)
        {
            bool kontrol = await _roomService.AddAsync(
                new Room
                {
                    RoomSituationId = roomVM.RoomSituationId,
                    RoomViewId=roomVM.RoomViewId,
                    RoomSize=roomVM.RoomSize,
                    RoomTypeId=roomVM.RoomTypeId,
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
        [Route("[action]")]
        public async Task<IActionResult> Put([FromBody] RoomVM roomVM)
        {
            Room room = _roomService.Get(roomVM.RoomName);
            if (room != null)
            {
                room.RoomSituationId = roomVM.RoomSituationId;
                room.RoomTypeId = roomVM.RoomTypeId;
                room.RoomViewId = roomVM.RoomViewId;
                room.RoomSize = roomVM.RoomSize;
                bool kontrol = await _roomService.UpdateAsync(room);
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
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateRoomSituation(int roomName,int situationId)
        {
            bool kontrol= await _roomService.RoomStatusUpdateAsync(roomName, situationId);
            if (kontrol)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{roomName}")]
        public async Task<IActionResult> Delete(int roomName)
        {
            bool kontrol = await _roomService.DeleteByIdAsync(roomName);
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
