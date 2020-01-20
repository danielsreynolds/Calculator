using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calculator.Models
{
    public class Deposit : Account
    {
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal AverageBalance { get; set; }
        [Required]
        [Range(0, 10000)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal InterestRate { get; set; }
        [Required]
        [Range(0, 100000000)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Cost { get; set; }
    }
}