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
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RolesController(IRoleService service)
        {
            _roleService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Role role = _roleService.GetById(id);
            if (role != null)
            {
                RoleVM roleVM = new RoleVM();
                roleVM.Id = role.Id;
                roleVM.RoleName = role.RoleName;
                return Ok(roleVM);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<RoleVM> roles = _roleService.GetAll().Select(x => new RoleVM { Id = x.Id, RoleName = x.RoleName }).ToList();
            return Ok(roles);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoleVM roleVM)
        {
            bool kontrol = await _roleService.AddAsync(
                new Role
                {
                    RoleName = roleVM.RoleName
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
        public async Task<IActionResult> Put([FromBody] RoleVM roleVM)
        {
            Role role = _roleService.GetById(roleVM.Id);
            if (role != null)
            {
                role.RoleName = roleVM.RoleName;
                bool kontrol = await _roleService.UpdateAsync(role);
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
            bool kontrol = await _roleService.DeleteByIdAsync(id);
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
