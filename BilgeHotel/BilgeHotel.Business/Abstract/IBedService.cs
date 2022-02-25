using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IBedService
    {
         List<Bed> GetAll();
         Bed GetById(int id);
         Task<bool> AddAsync(Bed bed);
         Task<bool> DeleteByIdAsync(int id);
         Task<bool> UpdateByAsync(Bed bed);
    }
}
