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
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService service)
        {
            _employeeService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Employee employee = _employeeService.GetById(id);
            if (employee != null)
            {
                EmployeeVM employeeVM = new EmployeeVM();
                employeeVM.Id = employee.Id;
                employeeVM.FirstName = employee.FirstName;
                employeeVM.LastName = employee.LastName;
                employeeVM.Phone = employee.Phone;
                employeeVM.Adress = employee.Adress;
                employeeVM.Salary = employee.Salary;
                employeeVM.RoleId = employee.RoleId;
                employeeVM.RoleName = employee.Role.RoleName;
                employeeVM.DepartmentId = employee.DepartmentId;
                employeeVM.DepartmentName = employee.Department.DepartmentName;
                return Ok(employeeVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<EmployeeVM> employees = _employeeService.GetAll().Select(x => new EmployeeVM {
                Id = x.Id, 
                FirstName = x.FirstName,
                LastName=x.LastName,
                Phone=x.Phone,
                Adress=x.Adress,
                Salary=x.Salary,
                RoleId=x.RoleId,
                RoleName=x.Role.RoleName,
                DepartmentId=x.DepartmentId,
                DepartmentName=x.Department.DepartmentName

            }).ToList();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeeVM employeeVM)
        {
            bool kontrol = await _employeeService.AddAsync(
                new Employee
                {
                    FirstName = employeeVM.FirstName,
                    LastName=employeeVM.LastName,
                    Phone=employeeVM.Phone,
                     Adress=employeeVM.Adress,
                     Salary=employeeVM.Salary,
                     RoleId=employeeVM.RoleId,
                     DepartmentId=employeeVM.DepartmentId
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
        public async Task<IActionResult> Put([FromBody] EmployeeVM employeeVM)
        {
            Employee employee = _employeeService.GetById(employeeVM.Id);
            if (employee != null)
            {
                employee.FirstName = employeeVM.FirstName;
                employee.LastName = employeeVM.LastName;
                employee.Phone = employeeVM.Phone;
                employee.Adress = employeeVM.Adress;
                employee.Salary = employeeVM.Salary;
                employee.RoleId = employeeVM.RoleId;
                employee.DepartmentId = employeeVM.DepartmentId;
                bool kontrol = await _employeeService.UpdateAsync(employee);
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
            bool kontrol = await _employeeService.DeleteByIdAsync(id);
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
