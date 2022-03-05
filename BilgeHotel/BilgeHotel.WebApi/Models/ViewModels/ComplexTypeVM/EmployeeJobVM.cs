using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels.ComplexTypeVM
{
    public class EmployeeJobVM
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public int DayId { get; set; }
        public string DayName { get; set; }

        public int ShifTimeId { get; set; }
        public TimeSpan ShiftTime { get; set; }
        public int JobId { get; set; }
        public string JobName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
