using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IRoleService
    {
        List<Role> GetAll();
        Role GetById(int id);
        Task<bool> AddAsync(Role role);
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(Role role);
    }
}
