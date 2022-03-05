using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels.ComplexTypeVM
{
    public class EmployeeJobPostVM
    {
        public int EmployeeId { get; set; }
        public int DayId { get; set; }
        public int JobId { get; set; }
        public int ShiftTimeId { get; set; }
        public int DepartmentId { get; set; }
    }
}
