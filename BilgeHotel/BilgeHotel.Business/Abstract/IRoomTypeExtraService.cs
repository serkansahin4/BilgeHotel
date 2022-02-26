using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IRoomTypeExtraService
    {
        List<RoomTypeExtra> GetAll(int roomTypeId);
        Task<bool> AddAsync(int roomTypeId,int extraId);
        Task<bool> DeleteByIdAsync(int roomTypeId,int extraId);
    }
}
