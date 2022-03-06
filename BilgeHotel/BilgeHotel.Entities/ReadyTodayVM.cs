using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities
{
    public class ReadyRoomTodayVM
    {
        public int RoomId { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public RoomVMSituation Situation { get; set; }
    }

    public enum RoomVMSituation
    {
        Hazır,
        Boşalacak
    }
}
