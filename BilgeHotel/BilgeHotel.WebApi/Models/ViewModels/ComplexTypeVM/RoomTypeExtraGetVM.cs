using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels.ComplexTypeVM
{
    public class RoomTypeExtraGetVM
    {
        public int RoomTypeId { get; set; }
        public int ExtraId { get; set; }
        public string RoomTypeName { get; set; }
        public string ExtraName { get; set; }
    }
}
