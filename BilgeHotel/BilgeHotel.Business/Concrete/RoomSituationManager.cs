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
    public class RoomSituationManager:IRoomSituationService
    {
        private readonly IRepository<RoomSituation> _repository;
        public RoomSituationManager(IRepository<RoomSituation> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(RoomSituation roomSituation)
        {
            bool kontrol = await _repository.Insert(roomSituation);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            RoomSituation roomSituation = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(roomSituation);
            return kontrol;
        }

        public List<RoomSituation> GetAll()
        {
            return _repository.GetAll();
        }

        public RoomSituation GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public async Task<bool> UpdateByAsync(RoomSituation roomSituation)
        {
            bool kontrol = await _repository.Update(roomSituation);
            return kontrol;
        }
    }
}
