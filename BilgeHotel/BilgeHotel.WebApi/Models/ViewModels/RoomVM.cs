using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels
{
    public class RoomVM
    {
        public int RoomName { get; set; }
        public Int16 RoomSize { get; set; }
        public int RoomTypeId { get; set; }
        public int RoomViewId { get; set; }
        public int RoomSituationId { get; set; }
    }
}
