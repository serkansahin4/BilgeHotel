using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels
{
    public class ShiftTimeVM
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan StopTime { get; set; }
    }
}
