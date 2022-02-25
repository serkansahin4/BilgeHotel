using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IRoomSituationService
    {
        List<RoomSituation> GetAll();
        RoomSituation GetById(int id);
        Task<bool> AddAsync(RoomSituation roomSituation);
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateByAsync(RoomSituation roomSituation);
    }
}
