using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IReservationService
    {

        
        Task<bool> Add(Reservation reservation);

        Task<bool> ReservationExtraPayment(Guid reservationId);

        double ReservationExtraPrice(Guid reservationId);

    }
}
