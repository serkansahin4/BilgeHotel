using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models
{
    public class Transaction
    {
        public Guid TransactionAdress { get; set; }
        public string CardNo { get; set; }
        public double Amount { get; set; }
        public bool Confirmation { get; set; }
    }
}
