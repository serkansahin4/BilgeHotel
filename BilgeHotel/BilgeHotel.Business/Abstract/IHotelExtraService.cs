using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IHotelExtraService
    {
        List<HotelExtra> GetAll();
        HotelExtra GetById(int id);
        Task<bool> AddAsync(HotelExtra hotelExtra);
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(HotelExtra hotelExtra);
    }
}
