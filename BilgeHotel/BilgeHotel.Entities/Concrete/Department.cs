using BilgeHotel.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Department : IEntity
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
