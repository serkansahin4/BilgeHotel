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
   public class HotelExtraManager:IHotelExtraService
    {
        private readonly IRepository<HotelExtra> _repository;
        public HotelExtraManager(IRepository<HotelExtra> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(HotelExtra hotelExtra)
        {
            bool kontrol = await _repository.Insert(hotelExtra);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            HotelExtra hotelExtra = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(hotelExtra);
            return kontrol;
        }

        public List<HotelExtra> GetAll()
        {
            return _repository.GetAll();
        }

        public HotelExtra GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(HotelExtra hotelExtra)
        {
            bool kontrol = await _repository.Update(hotelExtra);
            return kontrol;
        }
    }
}
