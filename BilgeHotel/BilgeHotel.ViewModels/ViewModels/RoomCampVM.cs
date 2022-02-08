using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.ViewModels.ViewModels
{
    public class RoomCampVM
    {
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public List<BedVM> RoomBeds { get; set; }
        public List<ImageVM> Images { get; set; }
    }
}
