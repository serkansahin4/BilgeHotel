using BilgeHotel.Core.MyTools.Concrete;
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
        List<DateTime> CheckInDates(int roomId);
        List<DateTime> CheckOutDates(List<DateTime> checkInDates, DateTime checkInDate);

        List<ReservationDetail> GetAll(int roomId);
        Task<bool> Add(ReservationDetail reservationDetail);
        ReservationDetail Get(Guid reservationId);
        

        double Discount(DateTime checkInDate, DateTime createdDate, int packageId);
        double DiscountedPrice(DateTime checkInDate, DateTime checkOutDate, double discount, double roomPrice, double packetPrice);
    }
}
