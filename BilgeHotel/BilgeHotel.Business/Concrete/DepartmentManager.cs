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
    public class DepartmentManager:IDepartmentService
    {
        private readonly IRepository<Department> _repository;
        public DepartmentManager(IRepository<Department> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(Department department)
        {
            bool kontrol = await _repository.Insert(department);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            Department department = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(department);
            return kontrol;
        }

        public List<Department> GetAll()
        {
            return _repository.GetAll();
        }

        public Department GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(Department department)
        {
            bool kontrol = await _repository.Update(department);
            return kontrol;
        }
    }
}
