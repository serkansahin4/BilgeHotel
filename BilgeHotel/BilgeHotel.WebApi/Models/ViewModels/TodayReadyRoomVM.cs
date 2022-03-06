using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels
{
    public class TodayReadyRoomVM
    {
        public int RoomName { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string Situation { get; set; }
    }
}
