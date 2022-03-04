using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class ShiftTime:IEntity
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan StopTime { get; set; }

        public virtual ICollection<EmployeeJob> EmployeeJobs { get; set; }
    }
}
