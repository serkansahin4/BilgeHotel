using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Day:IEntity
    {
        public int Id { get; set; }
        public string DayName { get; set; }
        public virtual ICollection<EmployeeJob> EmployeeJobs { get; set; }
    }
}
