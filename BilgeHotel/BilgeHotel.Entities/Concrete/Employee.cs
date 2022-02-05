using BilgeHotel.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public decimal Salary { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
        public virtual List<Shift> Shifts { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
