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
//            o en az bir ay önce yapılan herşey dahil rezervasyonlarda % 18,
//            o en az bir ay önce yapılan tam pansiyon rezervasyonlarda % 16,
//            o en az 3 ay önce yapılan rezervasyonlarda % 23 indirim.

            int different = (reservationDetail.CheckInDate - reservationDetail.CreatedDate).Days;
            int reservationDay = (reservationDetail.CheckOutDate - reservationDetail.CheckInDate).Days;
            if (different>90)
            {
                reservationDetail.Discount = 23;
                reservationDetail.DiscountedPrice = ((reservationDetail.Package.Price+reservationDetail.Room.RoomType.Price)*reservationDay * 23) / 100;
            }
            else if(different>30)
            {
                switch (reservationDetail.PackageId)
                {
                    case 1:
                        reservationDetail.Discount = 16;
                        reservationDetail.DiscountedPrice = ((reservationDetail.Package.Price + reservationDetail.Room.RoomType.Price)*reservationDay * 16) / 100;
                        break;
                    case 2:
                        reservationDetail.Discount = 18;
                        reservationDetail.DiscountedPrice = ((reservationDetail.Package.Price + reservationDetail.Room.RoomType.Price)*reservationDay * 18) / 100;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                reservationDetail.Discount = 0;
                reservationDetail.DiscountedPrice = (reservationDetail.Package.Price + reservationDetail.Room.RoomType.Price)*reservationDay;
            }

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
