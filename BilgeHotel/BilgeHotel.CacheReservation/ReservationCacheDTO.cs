using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.CacheReservation
{
    public class ReservationCacheDTO
    {
        public int RoomId { get; set; }
        public Guid ReservationIdentity { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
