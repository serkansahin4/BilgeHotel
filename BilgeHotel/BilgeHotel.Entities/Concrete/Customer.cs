using BilgeHotel.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Yav dgirsene")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TcIdentityNo { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
