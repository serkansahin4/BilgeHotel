using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebUI.Models.ViewModels
{
    public class ReservationCreateVM
    {
        public ReservationCreateVM()
        {
            CreatedDate = DateTime.Now;
        }
        public Customer Customer { get; set; }
        public int RoomId { get; set; }
        public int PackageId { get; set; }
        public DateTime CheckInDate { get; set; }
        
        public DateTime CheckOutDate { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}