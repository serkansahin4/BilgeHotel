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
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentsController(IDepartmentService service)
        {
            _departmentService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Department department = _departmentService.GetById(id);
            if (department != null)
            {
                DepartmentVM departmentVM = new DepartmentVM();
                departmentVM.Id = department.Id;
                departmentVM.DepartmentName = department.DepartmentName;
                return Ok(departmentVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<DepartmentVM> departments = _departmentService.GetAll().Select(x => new DepartmentVM { Id = x.Id, DepartmentName = x.DepartmentName }).ToList();
            return Ok(departments);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DepartmentVM departmentVM)
        {
            bool kontrol = await _departmentService.AddAsync(
                new Department
                {
                    DepartmentName = departmentVM.DepartmentName
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
        public async Task<IActionResult> Put([FromBody] DepartmentVM departmentVM)
        {
            Department department = _departmentService.GetById(departmentVM.Id);
            if (department != null)
            {
                department.DepartmentName = departmentVM.DepartmentName;
                bool kontrol = await _departmentService.UpdateAsync(department);
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
            bool kontrol = await _departmentService.DeleteByIdAsync(id);
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
