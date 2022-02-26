using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Concrete
{
    public class RoomBedManager:IRoomBedService
    {
        private readonly IRepository<RoomBed> _repository;

        public RoomBedManager(IRepository<RoomBed> repository)
        {
            _repository = repository;
        }
        public List<RoomBed> GetAll(int roomTypeId)
        {
            return _repository.GetAll(x=>x.RoomTypeId==roomTypeId);
        }

        public async Task<bool> AddAsync(int roomTypeId, int bedId)
        {
            return await _repository.Insert(new RoomBed {  BedId = bedId, RoomTypeId = roomTypeId });
        }

        public async Task<bool> DeleteByIdAsync(int roomTypeId, int bedId)
        {
            return await _repository.Delete(new RoomBed { RoomTypeId = roomTypeId, BedId = bedId });
        }
    }
}
