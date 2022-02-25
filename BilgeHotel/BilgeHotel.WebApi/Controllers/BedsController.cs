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
    public class BedsController : ControllerBase
    {
        private readonly IBedService _bedService;
        public BedsController(IBedService service)
        {
            _bedService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Bed bed = _bedService.GetById(id);
            if (bed != null)
            {
                BedVM bedVM = new BedVM();
                bedVM.Id = bed.Id;
                bedVM.BedType = bed.BedType;
                return Ok(bedVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<BedVM> beds = _bedService.GetAll().Select(x => new BedVM { Id = x.Id, BedType = x.BedType }).ToList();
            return Ok(beds);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BedVM bedVM)
        {
            bool kontrol = await _bedService.AddAsync(
                new Bed
                {
                    BedType = bedVM.BedType
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
        public async Task<IActionResult> Put([FromBody] BedVM bedVM)
        {
            Bed bed = _bedService.GetById(bedVM.Id);
            if (bed != null)
            {
                bed.BedType = bedVM.BedType;
                bool kontrol = await _bedService.UpdateByAsync(bed);
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
            bool kontrol = await _bedService.DeleteByIdAsync(id);
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
