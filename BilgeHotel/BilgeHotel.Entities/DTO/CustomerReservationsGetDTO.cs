using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.DTO
{
    public class CustomerReservationsGetDTO
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<ReservationDateDTO> reservationDates { get; set; } = new List<ReservationDateDTO>();
       
    }
}
