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
        public List<Room> GetAll()
        {
            return _repository.GetAll();
        }

        public double PriceGetById(int RoomName)
        {
            return _repository.Get(x => x.RoomName == RoomName).RoomType.Price;
        }
    }
}
