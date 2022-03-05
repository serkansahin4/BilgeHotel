using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IShiftService
    {
        List<Shift> GetAll(int employeeJobId);
        Shift Get(int shiftId);
        Task<bool> AddAsync(Shift shift);
    }
}
