using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Concrete
{
    public class EmployeeManager:IEmployeeService
    {
        private readonly IRepository<Employee> _repository;
        public EmployeeManager(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(Employee employee)
        {
            bool kontrol = await _repository.Insert(employee);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            Employee employee = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(employee);
            return kontrol;
        }

        public List<Employee> GetAll()
        {
            return _repository.GetAll();
        }

        public Employee GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(Employee employee)
        {
            bool kontrol = await _repository.Update(employee);
            return kontrol;
        }
    }
}
