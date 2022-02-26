using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels.ComplexTypeVM
{
    public class RoomBedGetVM
    {
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public int BedId { get; set; }
        public string BedName { get; set; }
    }
}
