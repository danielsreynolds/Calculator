using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calculator.Models
{
    public class Loan : Account
    {
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Balance { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal InterestRate { get; set; }
        [Required]
        [Range(0, 1000000000)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Income { get; set; }
        [Required]
        [Range(1, 600)]
        public int Term { get; set; }
    }
}