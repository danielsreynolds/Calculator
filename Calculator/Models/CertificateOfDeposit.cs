using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{

    public class CertificateOfDeposit
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int AccountNumber { get; set; }
        public string Type { get; set; }
        public string Term { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}