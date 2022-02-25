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
    public class ExtrasController : ControllerBase
    {
        private readonly IExtraService _extraService;
        public ExtrasController(IExtraService service)
        {
            _extraService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Extra extra = _extraService.GetById(id);
            if (extra != null)
            {
                ExtraVM extraVM = new ExtraVM();
                extraVM.Id = extra.Id;
                extraVM.ExtraName = extra.ExtraName;
                return Ok(extraVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<ExtraVM> extras = _extraService.GetAll().Select(x => new ExtraVM { Id = x.Id, ExtraName = x.ExtraName }).ToList();
            return Ok(extras);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ExtraVM extraVM)
        {
            bool kontrol = await _extraService.AddAsync(
                new Extra
                {
                    ExtraName = extraVM.ExtraName
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
        public async Task<IActionResult> Put([FromBody] ExtraVM extraVM)
        {
            Extra extra = _extraService.GetById(extraVM.Id);
            if (extra != null)
            {
                extra.ExtraName = extraVM.ExtraName;
                bool kontrol = await _extraService.UpdateAsync(extra);
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
            bool kontrol = await _extraService.DeleteByIdAsync(id);
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
