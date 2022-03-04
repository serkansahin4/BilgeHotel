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
    public class ShiftTimesController : ControllerBase
    {
        private readonly IShiftTimeService _shiftTimeService;
        public ShiftTimesController(IShiftTimeService shiftTimeService)
        {
            _shiftTimeService = shiftTimeService;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ShiftTime shiftTime = _shiftTimeService.Get(id);
            if (shiftTime != null)
            {
                ShiftTimeVM shiftTimeVM = new ShiftTimeVM();
                shiftTimeVM.Id = shiftTime.Id;
                shiftTimeVM.StartTime = shiftTime.StartTime;
                shiftTimeVM.StopTime = shiftTime.StopTime;
                return Ok(shiftTimeVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<ShiftTimeVM> departments = _shiftTimeService.GetAll().Select(x => new ShiftTimeVM { Id = x.Id, StartTime=x.StartTime, StopTime=x.StopTime }).ToList();
            return Ok(departments);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ShiftTimeVM shiftTimeVM)
        {
            bool kontrol = await _shiftTimeService.AddAsync(
                new ShiftTime
                {
                    StartTime = shiftTimeVM.StartTime,
                    StopTime=shiftTimeVM.StopTime
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
        public async Task<IActionResult> Put([FromBody] ShiftTimeVM shiftTimeVM)
        {
            ShiftTime shiftTime = _shiftTimeService.Get(shiftTimeVM.Id);
            if (shiftTime != null)
            {
                shiftTime.StartTime = shiftTimeVM.StartTime;
                shiftTime.StopTime = shiftTimeVM.StopTime;
                bool kontrol = await _shiftTimeService.UpdateAsync(shiftTime);
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
            bool kontrol = await _shiftTimeService.DeleteAsync(id);
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
