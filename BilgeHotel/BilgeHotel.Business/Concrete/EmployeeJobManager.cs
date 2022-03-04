using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Concrete
{
    public class EmployeeJobManager : IEmployeeJobService
    {
        private readonly IRepository<EmployeeJob> _repository;
        public EmployeeJobManager(IRepository<EmployeeJob> repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddAsync(EmployeeJob employeeJob)
        {
            return await _repository.Insert(employeeJob);
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            EmployeeJob employeeJob = _repository.Get(x => x.EmployeeId == id);
            return await _repository.Delete(employeeJob);
        }

        public List<EmployeeJob> GetAll()
        {
            return _repository.GetAll();
        }

        public EmployeeJob GetById(int id)
        {
            return _repository.Get(x => x.EmployeeId==id);
        }

        public async Task<bool> UpdateAsync(EmployeeJob employeeJob)
        {
            return await _repository.Update(employeeJob);
        }
    }
}
