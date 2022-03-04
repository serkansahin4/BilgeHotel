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
    public class JobsController : ControllerBase
    {
        private readonly IJobService _jobService;
        public JobsController(IJobService service)
        {
            _jobService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Job job = _jobService.GetById(id);
            if (job != null)
            {
                JobVM jobVM = new JobVM();
                jobVM.Id = job.Id;
                jobVM.JobName = job.JobName;
                return Ok(jobVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<JobVM> jobs = _jobService.GetAll().Select(x => new JobVM { Id = x.Id, JobName = x.JobName }).ToList();
            return Ok(jobs);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] JobVM jobVM)
        {
            bool kontrol = await _jobService.AddAsync(
                new Job
                {
                    JobName = jobVM.JobName
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
        public async Task<IActionResult> Put([FromBody] JobVM jobVM)
        {
            Job job = _jobService.GetById(jobVM.Id);
            if (job != null)
            {
                job.JobName = jobVM.JobName;
                bool kontrol = await _jobService.UpdateAsync(job);
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
            bool kontrol = await _jobService.DeleteByIdAsync(id);
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
