using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Calculator.Models
{
    public class Portfolio
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<Deposit> Deposits { get; set; }
        public ICollection<CreditCard> CreditCards { get; set; }
        public ICollection<CertificateOfDeposit> CertificateOfDeposits { get; set; }
        public ICollection<Loan> Loans { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}