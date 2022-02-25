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
    public class BedManager : IBedService
    {
        private readonly IRepository<Bed> _repository;
        public BedManager(IRepository<Bed> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(Bed bed)
        {
            bool kontrol = await _repository.Insert(bed);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            Bed bed = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(bed);
            return kontrol;
        }

        public List<Bed> GetAll()
        {
            return _repository.GetAll();
        }

        public Bed GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public async Task<bool> UpdateByAsync(Bed bed)
        {
            bool kontrol = await _repository.Update(bed);
            return kontrol;
        }
    }
}
