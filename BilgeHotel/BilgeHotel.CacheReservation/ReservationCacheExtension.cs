using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.CacheReservation
{
    public class ReservationCacheExtension
    {
        private static List<ReservationCacheDTO> ReservationCaches = new List<ReservationCacheDTO>();

        public bool CacheInAdd(ReservationCacheDTO reservationCacheDTO)
        {
           
            List<DateTime> dateTimes = new List<DateTime>();//Gelen Rezervasyon tarihlerini parçaladık.
            DateTime itemDateBaslangic = reservationCacheDTO.CheckInDate;
            DateTime itemDateBitis = reservationCacheDTO.CheckOutDate;
            for (DateTime tarih = itemDateBaslangic; tarih <= itemDateBitis; tarih = tarih.AddDays(1))
            {
                dateTimes.Add(tarih);
            }

            List<DateTime> dateTimes1 = new List<DateTime>();//ReservationCaches içerisindeki
                                                             //RoomıD Ye ait tarih aralıklarının
                                                             //İçerisinde dönüp listeye atıyoruz.
            foreach (ReservationCacheDTO item in ReservationCaches.Where(x => x.RoomId == reservationCacheDTO.RoomId))
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
                ReservationCaches.Add(reservationCacheDTO);
                return true;
            }
            return false;
        }
        public void CacheInRemove(Guid guid)
        {
            ReservationCacheDTO deleteReservation = ReservationCaches.Find(x => x.ReservationIdentity == guid);
            ReservationCaches.Remove(deleteReservation);
        }
    }
}
