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
    public class PackagesController : ControllerBase
    {
        private readonly IPackageService _packageService;
        public PackagesController(IPackageService service)
        {
            _packageService = service;
        }

        
        [HttpGet("GetByPrice/{id}")]
        public IActionResult GetByPrice(int id)
        {
            return Ok(_packageService.PriceGetById(id));
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            Package package = _packageService.GetById(id);
            if (package != null)
            {
                PackageVM packageVM = new PackageVM();
                packageVM.Id = package.Id;
                packageVM.Price = package.Price;
                packageVM.PackageName = package.PackageName;
                return Ok(packageVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<PackageVM> packages = _packageService.GetAll().Select(x => new PackageVM { Id = x.Id, Price=x.Price, PackageName = x.PackageName }).ToList();
            return Ok(packages);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PackageVM packageVM)
        {
            bool kontrol = await _packageService.AddAsync(
                new Package
                {
                    PackageName = packageVM.PackageName,
                    Price=packageVM.Price
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
        public async Task<IActionResult> Put([FromBody] PackageVM packageVM)
        {
            Package package = _packageService.GetById(packageVM.Id);
            if (package != null)
            {
                package.PackageName = packageVM.PackageName;
                package.Price = packageVM.Price;
                bool kontrol = await _packageService.UpdateAsync(package);
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
            bool kontrol = await _packageService.DeleteByIdAsync(id);
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
