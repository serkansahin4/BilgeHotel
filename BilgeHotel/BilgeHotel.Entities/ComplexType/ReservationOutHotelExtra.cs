using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.ComplexType
{
    public class ReservationOutHotelExtra : IEntity
    {
        public int HotelExtraId { get; set; }
        public Guid ReservationId { get; set; }
        public Int16 Quantity { get; set; }

        public virtual HotelExtra HotelExtra { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
