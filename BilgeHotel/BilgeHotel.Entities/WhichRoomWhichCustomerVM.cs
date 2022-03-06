using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using BilgeHotel.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities
{
    public class WhichRoomWhichCustomerVM
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int RoomName { get; set; }
        public List<ReservationDateDTO> reservationDetails { get; set; } = new List<ReservationDateDTO>();
        
    }
}
