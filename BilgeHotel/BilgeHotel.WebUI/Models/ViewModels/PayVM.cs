using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebUI.Models.ViewModels
{
    public class PayVM
    {
        public int CardTypeId { get; set; }
        public string CardNumber { get; set; }
        public string CV2 { get; set; }
        public string EndDate { get; set; }
    }
}
