using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
        Department GetById(int id);
        Task<bool> AddAsync(Department department);
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(Department department);
    }
}
