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
    public class RoomManager : IRoomService
    {
        private readonly IRepository<Room> _repository;
        public RoomManager(IRepository<Room> repository)
        {
            _repository = repository;
        }
        public List<Room> GetAllReady(int roomTypeId)
        {
            return _repository.GetAll(x=>x.RoomSituation.Id==1&&x.RoomTypeId==roomTypeId);
        }

        public double PriceGetById(int RoomName)
        {
            return _repository.Get(x => x.RoomName == RoomName).RoomType.Price;
        }



        public async Task<bool> AddAsync(Room room)
        {
            bool kontrol = await _repository.Insert(room);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int roomName)
        {
            Room room = _repository.Get(x => x.RoomName == roomName);
            bool kontrol = await _repository.Delete(room);
            return kontrol;
        }

        public List<Room> GetAll()
        {
            return _repository.GetAll();
        }

        public Room Get(int roomName)
        {
            return _repository.Get(x => x.RoomName == roomName);
        }

        public async Task<bool> UpdateAsync(Room room)
        {
            bool kontrol = await _repository.Update(room);
            return kontrol;
        }
    }
}
