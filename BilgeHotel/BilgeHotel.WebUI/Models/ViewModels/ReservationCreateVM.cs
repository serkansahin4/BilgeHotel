using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebUI.Models.ViewModels
{
    public class ReservationCreateVM
    {
        public Customer Customer { get; set; }
        public int RoomId { get; set; }
        public int PackageId { get; set; }
        public int Discount { get; set; }
        public int DiscountedPrice { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}