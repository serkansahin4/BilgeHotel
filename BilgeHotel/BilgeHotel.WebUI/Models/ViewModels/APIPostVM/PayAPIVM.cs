using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebUI.Models.ViewModels.APIPostVM
{
    public class PayAPIVM
    {
        public string CardNo { get; set; }
        public string CV2 { get; set; }
        public string EndDate { get; set; }
        public double Amount { get; set; }
    }
}
