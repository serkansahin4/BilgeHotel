using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels.ComplexTypeVM
{
    public class ShiftPostVM
    {
        public int EmployeeJobId { get; set; }
        public DateTime StartShift { get; set; }
        public DateTime StopShift { get; set; }
        public DateTime ExtraTimeStop { get; set; }
    }
}
