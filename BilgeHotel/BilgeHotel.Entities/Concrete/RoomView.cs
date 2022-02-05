using BilgeHotel.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class RoomView : IEntity
    {
        public int Id { get; set; }
        public string ViewName { get; set; }

        public virtual List<Room> Rooms { get; set; }
    }
}
