using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Concrete
{
    public class ReservationDetailManager : IReservationDetailService
    {
        private readonly IRepository<ReservationDetail> _repository;
        public ReservationDetailManager(IRepository<ReservationDetail> repository)
        {
            _repository = repository;
        }

        public void Add(ReservationDetail reservationDetail)
        {
            _repository.Insert(reservationDetail);
            
        }

        
        public List<ReservationDetail> GetAll(int roomId)
        {
            return _repository.GetAll(x => x.RoomId == roomId).ToList();
        }

        public double Discount(DateTime checkInDate, DateTime createdDate, int packageId)
        {
            int reservationDayCount = (checkInDate - createdDate).Days;
            if (reservationDayCount>90)
            {
                return 23;
            }
            else if (reservationDayCount > 30)
            {
                switch (packageId)
                {
                    case 1:
                        return 16;
                    case 2:
                        return 18;
                    default:
                        return 1;
                }
            }
            else
            {
                return 1;
            }
        }

        public double DiscountedPrice(DateTime checkInDate, DateTime checkOutDate, double Discount, double RoomPrice, double PacketPrice)
        {
            int howDay = (checkOutDate - checkInDate).Days;
            return ((RoomPrice + PacketPrice) * howDay * (100 - Discount)) / 100;
        }

    }
}
