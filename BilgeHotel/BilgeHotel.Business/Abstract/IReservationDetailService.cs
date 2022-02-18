using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IReservationDetailService
    {
        List<ReservationDetail> GetAll(int roomId);
        void Add(ReservationDetail reservationDetail);

        double Discount(DateTime checkInDate, DateTime createdDate, int packageId);
        double DiscountedPrice(DateTime checkInDate, DateTime checkOutDate, double discount, double roomPrice, double packetPrice);
    }
}
