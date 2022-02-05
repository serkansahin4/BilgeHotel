using BilgeHotel.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Shift : IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartShift { get; set; }
        public DateTime StopShift { get; set; }
        public DateTime ShiftDate { get; set; }
        public Int16 ExtraShift { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
