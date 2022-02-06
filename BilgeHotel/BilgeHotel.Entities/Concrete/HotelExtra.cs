using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class HotelExtra : IEntity
    {
        public int Id { get; set; }
        public string ExtraName { get; set; }
        public double Price { get; set; }

        public virtual List<ReservationOutHotelExtra> ReservationOutHotelExtras { get; set; }
    }
}
