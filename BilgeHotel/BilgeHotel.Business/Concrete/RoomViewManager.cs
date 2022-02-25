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
    public class RoomViewManager : IRoomViewService
    {
        private readonly IRepository<RoomView> _repository;
        public RoomViewManager(IRepository<RoomView> repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddAsync(RoomView roomView)
        {
            bool kontrol = await _repository.Insert(roomView);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            RoomView roomView = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(roomView);
            return kontrol;
        }

        public List<RoomView> GetAll()
        {
            return _repository.GetAll();
        }

        public RoomView GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(RoomView roomView)
        {
            bool kontrol = await _repository.Update(roomView);
            return kontrol;
        }
    }
}
