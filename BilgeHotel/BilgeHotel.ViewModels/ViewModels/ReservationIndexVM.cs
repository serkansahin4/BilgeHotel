using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.ViewModels.ViewModels
{
    public class ReservationIndexVM
    {
        public List<RoomType> RoomTypes { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
