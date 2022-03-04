using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IShiftTimeService
    {
        List<ShiftTime> GetAll();
        ShiftTime Get(int Id);
        Task<bool> AddAsync(ShiftTime time);
        Task<bool> UpdateAsync(ShiftTime time);
        Task<bool> DeleteAsync(int id);
    }
}
