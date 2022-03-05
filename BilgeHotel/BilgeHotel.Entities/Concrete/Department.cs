using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Department : IEntity
    {
        public Department()
        {
            EmployeeJob = new List<EmployeeJob>();
        }
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public virtual List<EmployeeJob> EmployeeJob { get; set; }
    }
}
