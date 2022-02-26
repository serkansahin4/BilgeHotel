using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.ComplexType
{
    public class ReservationDetail : IEntity
    {
        public ReservationDetail()
        {
            CreatedDate = DateTime.Now;
        }
        public Guid ReservationId { get; set; }
        public int RoomId { get; set; }
        public int PackageId { get; set; }
        public Guid? CardId { get; set; }
        public double? Discount { get; set; }
        public double? DiscountedPrice { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime CreatedDate { get; set; }


        public virtual Reservation Reservation { get; set; }
        public virtual Package Package { get; set; }
        public virtual Room Room { get; set; }
        public virtual Card Card { get; set; }
    }
}
