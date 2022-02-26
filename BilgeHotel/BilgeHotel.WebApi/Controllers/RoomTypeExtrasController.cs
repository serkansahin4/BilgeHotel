using BilgeHotel.Business.Abstract;
using BilgeHotel.Entities.ComplexType;
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
    public class RoomTypeExtrasController : ControllerBase
    {
        private readonly IRoomTypeExtraService _roomTypeExtraService;
        public RoomTypeExtrasController(IRoomTypeExtraService roomTypeExtraService)
        {
            _roomTypeExtraService = roomTypeExtraService;

        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int roomTypeId, int extraId)
        {
            bool kontrol = await _roomTypeExtraService.DeleteByIdAsync(roomTypeId, extraId);
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
        public async Task<IActionResult> Post([FromBody] RoomTypeExtraPostVM postVM)
        {
            bool kontrol = await _roomTypeExtraService.AddAsync(postVM.RoomTypeId, postVM.ExtraId);
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
            List<RoomTypeExtraGetVM> getVM = _roomTypeExtraService.GetAll(roomTypeId).Select(x => new RoomTypeExtraGetVM { ExtraId = x.ExtraId, ExtraName = x.Extra.ExtraName, RoomTypeId = x.RoomTypeId, RoomTypeName = x.RoomType.RoomTypeName }).ToList();
            return Ok(getVM);
        }
    }
}
