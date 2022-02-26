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
    public class RoomBedsController : ControllerBase
    {
        private readonly IRoomBedService _roomTypeExtraService;
        public RoomBedsController(IRoomBedService roomTypeExtraService)
        {
            _roomTypeExtraService = roomTypeExtraService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int roomTypeId, int bedId)
        {
            bool kontrol = await _roomTypeExtraService.DeleteByIdAsync(roomTypeId, bedId);
            if (kontrol)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }



        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoomBedGetVM postVM)
        {
            bool kontrol = await _roomTypeExtraService.AddAsync(postVM.RoomTypeId, postVM.BedId);
            if (kontrol)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }



        [HttpGet("{roomTypeId}")]
        public IActionResult Get(int roomTypeId)
        {
            List<RoomBedGetVM> getVM = _roomTypeExtraService.GetAll(roomTypeId).Select(x => new RoomBedGetVM { BedId = x.BedId, BedName = x.Bed.BedType, RoomTypeId = x.RoomTypeId, RoomTypeName = x.RoomType.RoomTypeName }).ToList();
            return Ok(getVM);
        }
    }
}
