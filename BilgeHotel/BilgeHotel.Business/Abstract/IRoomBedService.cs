using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IRoomBedService
    {
        List<RoomBed> GetAll(int roomTypeId);
        Task<bool> AddAsync(int roomTypeId, int roomBedId);
        Task<bool> DeleteByIdAsync(int roomTypeId, int roomBedId);
    }
}
