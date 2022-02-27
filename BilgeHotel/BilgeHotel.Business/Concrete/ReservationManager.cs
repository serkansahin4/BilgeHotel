using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using BilgeHotel.Entities.DTO;
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

        public bool Control(List<ReservationControlDTO> reservationDTOs,DateTime CheckInDate, DateTime CheckOutDate, int roomId)
        {
            List<DateTime> dateTimes = new List<DateTime>();//Gelen Rezervasyon tarihlerini parçaladık.
            DateTime itemDateBaslangic = CheckInDate;
            DateTime itemDateBitis = CheckOutDate;
            for (DateTime tarih = itemDateBaslangic; tarih <= itemDateBitis; tarih = tarih.AddDays(1))
            {
                dateTimes.Add(tarih);
            }

            List<DateTime> dateTimes1 = new List<DateTime>();//ReservationCaches içerisindeki
                                                             //RoomıD Ye ait tarih aralıklarının
                                                             //İçerisinde dönüp listeye atıyoruz.
            foreach (ReservationControlDTO item in reservationDTOs.Where(x => x.roomId == roomId))
            {

                DateTime itemDateBaslangic1 = item.CheckInDate;
                DateTime itemDateBitis1 = item.CheckOutDate;
                for (DateTime tarih = itemDateBaslangic1; tarih <= itemDateBitis1; tarih = tarih.AddDays(1))
                {
                    dateTimes1.Add(tarih);
                }
            }
            foreach (var item in dateTimes)
            {
                foreach (var items in dateTimes1)
                {
                    if (items == item)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
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
