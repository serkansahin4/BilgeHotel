using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IEmployeeJobService
    {
        List<EmployeeJob> GetAll();
        EmployeeJob GetById(int id);
        Task<bool> AddAsync(EmployeeJob employeeJob);
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(EmployeeJob employeeJob);
    }
}
