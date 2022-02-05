using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.ComplexType
{
    public class RoomBed : IEntity
    {
        public int RoomId { get; set; }
        public int BedId { get; set; }

        public virtual Room Room { get; set; }
        public virtual Bed Bed { get; set; }
    }
}
