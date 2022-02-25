using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels
{
    public class CardVM
    {
        public Guid Id { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string CV2 { get; set; }
        public string EndDate { get; set; }
    }
}
