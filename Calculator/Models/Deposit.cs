using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Deposit
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int AccountNumber { get; set; }
        public string Type { get; set; }
        public decimal AverageBalance { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Cost { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}