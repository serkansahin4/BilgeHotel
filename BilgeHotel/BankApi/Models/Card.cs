using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models
{
    public class Card
    {
        public string KartNo { get; set; }
        public string CV2 { get; set; }
        public string EndDate { get; set; }
        public string Mail { get; set; }
        public double Balance { get; set; }
    }
}
