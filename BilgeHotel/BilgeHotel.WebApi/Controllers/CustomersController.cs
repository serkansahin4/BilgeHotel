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
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService service)
        {
            _customerService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string identity)
        {
            Customer customer = _customerService.GetByIdentity(identity);
            if (customer != null)
            {
                CustomerVM customerVM = new CustomerVM();
                customerVM.Id = customer.Id;
                customerVM.FirstName = customer.FirstName;
                customerVM.LastName = customer.LastName;
                customerVM.Email = customer.Email;
                customerVM.BirthDate = customer.BirthDate;
                customerVM.Phone = customer.Phone;
                customerVM.TcIdentityNo = customer.TcIdentityNo;
                return Ok(customerVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<CustomerVM> customers = _customerService.GetAll().Select(x => new CustomerVM { Id = x.Id, FirstName = x.FirstName, LastName = x.LastName,  Email = x.Email,  BirthDate = x.BirthDate, Phone=x.Phone, TcIdentityNo=x.TcIdentityNo }).ToList();
            return Ok(customers);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string identity)
        {
            bool kontrol = await _customerService.DeleteByIdentityAsync(identity);
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
