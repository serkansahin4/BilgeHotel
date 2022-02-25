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
    public class RoleManager:IRoleService
    {
        private readonly IRepository<Role> _repository;
        public RoleManager(IRepository<Role> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(Role role)
        {
            bool kontrol = await _repository.Insert(role);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            Role role = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(role);
            return kontrol;
        }

        public List<Role> GetAll()
        {
            return _repository.GetAll();
        }

        public Role GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(Role role)
        {
            bool kontrol = await _repository.Update(role);
            return kontrol;
        }
    }
}
