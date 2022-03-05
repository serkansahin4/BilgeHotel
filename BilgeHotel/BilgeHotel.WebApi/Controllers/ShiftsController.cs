using BilgeHotel.Business.Abstract;
using BilgeHotel.Entities.Concrete;
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
    public class ShiftsController : ControllerBase
    {
        private readonly IShiftService _shiftService;
        public ShiftsController(IShiftService shiftService)
        {
            _shiftService = shiftService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ShiftPostVM shiftPostVM)
        {
            bool kontrol = await _shiftService.AddAsync(
                new Shift
                {
                    EmployeeJobId = shiftPostVM.EmployeeJobId,
                    StartShift = shiftPostVM.StartShift,
                    StopShift = shiftPostVM.StopShift,
                    ExtraTimeStop = shiftPostVM.ExtraTimeStop,
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


        [HttpGet("GetByShiftId/{id}")]
        public IActionResult GetByShiftId(int id)
        {
            Shift shift = _shiftService.Get(id);
            if (shift != null)
            {
                ShiftGetVM shiftGetVM = new ShiftGetVM();
                shiftGetVM.Id = shiftGetVM.Id;
                shiftGetVM.StartShift = shift.StartShift;
                shiftGetVM.StopShift = shift.StopShift;
                shiftGetVM.EmployeeJobId = shift.EmployeeJobId;
                shiftGetVM.ExtraTimeStop = shift.ExtraTimeStop;
                return Ok(shiftGetVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("GetByEmployeeId/{id}")]
        public IActionResult GetByEmployeeId(int id)
        {
            List<ShiftGetVM> shifts = _shiftService.GetAll(id).Select(x => new ShiftGetVM { Id = x.Id, StartShift = x.StartShift, StopShift=x.StopShift, EmployeeJobId=x.EmployeeJobId, ExtraTimeStop=x.ExtraTimeStop }).ToList();
            return Ok(shifts);
        }


    }
}
