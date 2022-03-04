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
    public class ShiftTimeManager : IShiftTimeService
    {
        private readonly IRepository<ShiftTime> _repository;
        public ShiftTimeManager(IRepository<ShiftTime> repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddAsync(ShiftTime time)
        {
            return await _repository.Insert(time);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            ShiftTime shiftTime = _repository.Get(x => x.Id == id);
             return await _repository.Delete(shiftTime);

        }

        public ShiftTime Get(int Id)
        {
            return _repository.Get(x => x.Id == Id);
        }

        public List<ShiftTime> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<bool> UpdateAsync(ShiftTime time)
        {
            return await _repository.Update(time);
        }
    }
}
