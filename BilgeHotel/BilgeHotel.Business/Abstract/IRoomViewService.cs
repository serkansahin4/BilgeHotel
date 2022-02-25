using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IRoomViewService
    {
        List<RoomView> GetAll();
        RoomView GetById(int id);
        Task<bool> AddAsync(RoomView roomView);
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(RoomView roomView);
    }
}
