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
    public class ReservationManager : IReservationService
    {
        private readonly IRepository<Reservation> _repository;
        public ReservationManager(IRepository<Reservation> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Add(Reservation reservation)
        {
            await _repository.Insert(reservation);
            return true;
        }

        public double ReservationExtraPrice(Guid reservationId) //Önce Fiyatı Gör.
        {
            double sumExtraPrice=0;
            foreach (var item in _repository.Get(x => x.Id == reservationId).ReservationOutHotelExtras)
            {
                double extraPrice = item.HotelExtra.Price;
                double quantity = item.Quantity;
                sumExtraPrice = extraPrice * quantity;
            }
            return sumExtraPrice;
        }

        public async Task<bool> ReservationExtraPayment(Guid reservationId) //Sonra Çıkış Yap.
        {
            Reservation reservation = _repository.Get(x => x.Id == reservationId);
            
            if (reservation!=null)
            {
                reservation.Out = true;
                await _repository.Update(reservation);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
