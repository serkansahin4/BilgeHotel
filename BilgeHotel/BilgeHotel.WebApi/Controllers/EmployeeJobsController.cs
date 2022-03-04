using BilgeHotel.Business.Abstract;
using BilgeHotel.Entities.ComplexType;
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
    public class EmployeeJobsController : ControllerBase
    {
        private readonly IEmployeeJobService _employeeJobService;
        public EmployeeJobsController(IEmployeeJobService service)
        {
            _employeeJobService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            EmployeeJob employeeJob = _employeeJobService.GetById(id);
            if (employeeJob != null)
            {
                EmployeeJobVM employeeJobVM = new EmployeeJobVM();
                employeeJobVM.EmployeeId = employeeJob.EmployeeId;
                employeeJobVM.EmployeeName = employeeJob.Employee.FirstName;
                employeeJobVM.DayId = employeeJob.DayId;
                employeeJobVM.DayName = employeeJob.Day.DayName;
                employeeJobVM.JobId = employeeJob.JobId;
                employeeJobVM.JobName = employeeJob.Job.JobName;
                employeeJobVM.ShifTimeId = employeeJob.ShiftTimeId;
                employeeJobVM.ShiftTime = employeeJob.ShiftTime.StartTime;
                return Ok(employeeJobVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<EmployeeJobVM> employeeJobs = _employeeJobService.GetAll().Select(x => new EmployeeJobVM { EmployeeId = x.EmployeeId, EmployeeName = x.Employee.FirstName, DayId = x.DayId, DayName = x.Day.DayName, JobId = x.JobId, JobName = x.Job.JobName, ShifTimeId = x.ShiftTimeId, ShiftTime = x.ShiftTime.StartTime }).ToList();
            return Ok(employeeJobs);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeeJobPostVM employeeJobPostVM)
        {
            bool kontrol = await _employeeJobService.AddAsync(
                new EmployeeJob
                {
                    DayId = employeeJobPostVM.DayId,
                    EmployeeId = employeeJobPostVM.EmployeeId,
                    JobId = employeeJobPostVM.JobId,
                    ShiftTimeId = employeeJobPostVM.ShiftTimeId,
                    Shifts=new List<Shift> { new Shift { EmployeeJobId=employeeJobPostVM.EmployeeId,StartShift=employeeJobPostVM.Shift.StartShift, StopShift=employeeJobPostVM.Shift.StopShift, ExtraTimeStop=employeeJobPostVM.Shift.ExtraTimeStop } }
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
        public async Task<IActionResult> Put([FromBody] EmployeeJobPostVM employeeJobPostVM)
        {
            EmployeeJob employeeJob = _employeeJobService.GetById(employeeJobPostVM.EmployeeId);
            if (employeeJob != null)
            {
                employeeJob.DayId = employeeJobPostVM.DayId;
                employeeJob.JobId = employeeJobPostVM.JobId;
                employeeJob.ShiftTimeId = employeeJobPostVM.ShiftTimeId;
                
                bool kontrol = await _employeeJobService.UpdateAsync(employeeJob);
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
            bool kontrol = await _employeeJobService.DeleteByIdAsync(id);
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
