using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels.ComplexTypeVM
{
    public class ReservationOutHotelExtraGetVM
    {
        public int HotelExtraId { get; set; }
        public string HotelExtraName { get; set; }
        public Guid ReservationId { get; set; }
        public int Quantity { get; set; }

    }
}
