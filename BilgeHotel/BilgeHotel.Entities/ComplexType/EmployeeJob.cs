using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.ComplexType
{
    public class EmployeeJob:IEntity
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; } 
        public int JobId { get; set; }
        public virtual Job Job { get; set; }

        public int DayId { get; set; }
        public virtual Day Day { get; set; }

        public int ShiftTimeId { get; set; }
        public virtual ShiftTime ShiftTime { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
