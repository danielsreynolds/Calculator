using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calculator.Models
{
    public class CertificateOfDeposit : Account
    {
        [Required]
        [Range(1, 1000)]
        public int Term { get; set; }
        [Required]
        [Range(0, 10000)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal InterestRate { get; set; }
    }
}