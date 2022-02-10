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
        public int RoomTypeId { get; set; }
        public int BedId { get; set; }
        public int Quantity { get; set; }

        public virtual RoomType RoomType { get; set; }
        public virtual Bed Bed { get; set; }
    }
}
