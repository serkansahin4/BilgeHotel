using BilgeHotel.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class RoomSituation : IEntity
    {
        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual List<Room> Rooms { get; set; }
    }
}
