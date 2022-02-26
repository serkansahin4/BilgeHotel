using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels
{
    public class RoomTypeVM
    {
        public int Id { get; set; }
        public string RoomTypeName { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
