using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels.ComplexTypeVM
{
    public class ReservationOutHotelExtraPostVM
    {
        public Guid ReservationId { get; set; }
        public int HotelExtraId { get; set; }
        public short Quantity { get; set; }
    }
}
