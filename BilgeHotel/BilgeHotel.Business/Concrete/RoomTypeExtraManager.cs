using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Concrete
{
    public class RoomTypeExtraManager:IRoomTypeExtraService
    {
        private readonly IRepository<RoomTypeExtra> _repository;
        
        public RoomTypeExtraManager(IRepository<RoomTypeExtra> repository,IRepository<Extra> extra, IRepository<RoomType> roomType)
        {
            _repository = repository;
        }
        public List<RoomTypeExtra> GetAll(int roomTypeId)
        {
            return _repository.GetAll(x=>x.RoomTypeId==roomTypeId);
        }

        public async Task<bool> AddAsync(int roomTypeId, int extraId)
        {
            return await _repository.Insert(new RoomTypeExtra { ExtraId = extraId, RoomTypeId = roomTypeId });
        }

        public async Task<bool> DeleteByIdAsync(int roomTypeId, int extraId)
        {
            return await _repository.Delete(new RoomTypeExtra { RoomTypeId = roomTypeId, ExtraId = extraId });
        }

        
    }
}
