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
    public class RoomTypeManager : IRoomTypeService
    {
        private readonly IRepository<RoomType> _repository;
        public RoomTypeManager(IRepository<RoomType> repository)
        {
            _repository = repository;
        }

        public RoomType Get(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public List<RoomType> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
