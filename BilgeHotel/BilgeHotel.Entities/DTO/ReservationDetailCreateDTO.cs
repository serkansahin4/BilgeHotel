using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.DTO
{
    public class ReservationDetailCreateDTO
    {
        //RoomId = reservations.RoomId,
        //        PackageId = reservations.PackageId,
        //        CheckInDate = reservations.CheckInDate,
        //        CheckOutDate = reservations.CheckOutDate,
        public int RoomId { get; set; }
        public int PackageId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
