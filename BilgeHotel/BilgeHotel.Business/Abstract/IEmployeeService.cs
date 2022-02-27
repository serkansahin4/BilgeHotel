using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        Task<bool> AddAsync(Employee employee);
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(Employee employee);
    }
}
