using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class RoomType : IEntity
    {
        public int Id { get; set; }
        public string RoomTypeName { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual List<Image> Images { get; set; }
        public virtual List<Room> Rooms { get; set; }
        public virtual List<RoomBed> RoomBeds { get; set; }
        public virtual List<RoomTypeExtra> RoomTypeExtras { get; set; }
    }
}
