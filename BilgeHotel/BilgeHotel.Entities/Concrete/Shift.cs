using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Shift : IEntity
    {
        public Shift()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime StartShift { get; set; }
        public DateTime StopShift { get; set; }
        public DateTime ExtraTimeStop { get; set; }
        public DateTime CreatedDate { get; set; }

        public int EmployeeJobId { get; set; }
        public virtual EmployeeJob EmployeeJob { get; set; }

    }
}
