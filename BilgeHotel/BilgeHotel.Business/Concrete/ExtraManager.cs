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
    public class ExtraManager : IExtraService
    {
        private readonly IRepository<Extra> _repository;
        public ExtraManager(IRepository<Extra> repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddAsync(Extra extra)
        {
            bool kontrol = await _repository.Insert(extra);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            Extra extra = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(extra);
            return kontrol;
        }

        public List<Extra> GetAll()
        {
            return _repository.GetAll();
        }

        public Extra GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(Extra extra)
        {
            bool kontrol = await _repository.Update(extra);
            return kontrol;
        }
    }
}
