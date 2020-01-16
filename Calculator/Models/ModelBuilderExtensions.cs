using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            string portfolioId = Guid.NewGuid().ToString();

            modelBuilder.Entity<Portfolio>().HasData(
                new Portfolio
                {
                    Id = portfolioId,
                    Name = "Nim Sum",
                    Type = "Normal"
                }
            );

            modelBuilder.Entity<CertificateOfDeposit>().HasData(
                new CertificateOfDeposit
                {
                    PortfolioId = portfolioId,
                    AccountNumber = 123456789,
                    Type = "Normal",
                    Term = 12,
                    InterestRate = 5
                }
            );

            modelBuilder.Entity<CreditCard>().HasData(
                new CreditCard
                {
                    PortfolioId = portfolioId,
                    AccountNumber = 123321123,
                    Type = "Normal",
                    Balance = 500,
                    InterestRate = 17,
                    Income = 1123,
                    UsageByPercentage = 50,
                }
            );

            modelBuilder.Entity<Deposit>().HasData(
                new Deposit
                {
                    PortfolioId = portfolioId,
                    AccountNumber = 321321321,
                    Type = "Normal",
                    AverageBalance = 5432,
                    InterestRate = .32m,
                    Cost = 500,
                }
            );

            modelBuilder.Entity<Loan>().HasData(
                new Loan
                {
                    PortfolioId = portfolioId,
                    AccountNumber = 54323453,
                    Type = "Car",
                    Balance = 9080,
                    InterestRate = 3.32m,
                    Income = 500,
                    Term = 48,
                }
            );
        }
    }
}
