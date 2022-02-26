using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IReservationOutHotelExtraService
    {
        List<ReservationOutHotelExtra> GetAll(Guid reservationId);
        Task<bool> AddAsync(Guid reservationId, int hotelExtraId,short quantity);
        Task<bool> DeleteByIdAsync(Guid reservationId, int hotelExtraId);
    }
}
