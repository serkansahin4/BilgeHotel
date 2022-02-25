using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IExtraService
    {
        List<Extra> GetAll();
        Extra GetById(int id);
        Task<bool> AddAsync(Extra Extra);
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(Extra Extra);
    }
}
