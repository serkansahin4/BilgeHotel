using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.DTO
{
    public class ReservationDetailCheckOutDTO
    {
        public List<DateTime> checkInDates { get; set; }
        public DateTime checkInDate { get; set; }
    }
}
