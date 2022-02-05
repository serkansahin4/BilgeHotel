using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.ComplexType
{
    public class RoomTypeExtra : IEntity
    {
        public int RoomTypeId { get; set; }
        public int ExtraId { get; set; }

        public virtual RoomType RoomType { get; set; }
        public virtual Extra Extra { get; set; }
    }
}
