using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Calculator.Models
{
    public class Portfolio
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [MaxLength(70)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
        public ICollection<Deposit> Deposits { get; set; }
        public ICollection<CreditCard> CreditCards { get; set; }
        public ICollection<CertificateOfDeposit> CertificateOfDeposits { get; set; }
        public ICollection<Loan> Loans { get; set; }
        [MaxLength(280)]
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}