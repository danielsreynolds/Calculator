using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{

    public class CertificateOfDeposit
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int AccountNumber { get; set; }
        public string Type { get; set; }
        public int Term { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal InterestRate { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string PortfolioId { get; set; }
    }

}