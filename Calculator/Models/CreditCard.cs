using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calculator.Models
{
    public class CreditCard : Account
    {
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Balance { get; set; }
        [Required]
        [Range(0, 10000)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal InterestRate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Income { get; set; }
        [Required]
        [Range(0, 100)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal UsageByPercentage { get; set; }
    }
}