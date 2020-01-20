using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calculator.Models
{
    public class Loan
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int AccountNumber { get; set; }
        public string Type { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Balance { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal InterestRate { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Income { get; set; }

        public int Term { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string PortfolioId { get; set; }
    }
}