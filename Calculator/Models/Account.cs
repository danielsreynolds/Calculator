using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Account
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public int AccountNumber { get; set; }
        [Required]
        [ForeignKey("Portfolio")]
        public string PortfolioId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
