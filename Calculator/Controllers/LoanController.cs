using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    public class LoanController : Controller
    {
        private readonly AppDBContext _context;

        public LoanController(AppDBContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index(string id)
        {
            if (id != null)
            {
                return RedirectToAction("Details", new { id });
            };

            return Ok(_context.Loans);
        }

        public IActionResult Details(string id)
        {
            if (id != null)
            {
                return Ok(_context.Loans.Find(id));
            };

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create([FromBody]Loan model)
        {
            if (ModelState.IsValid)
            {
                Loan loan = new Loan
                {
                    AccountNumber = model.AccountNumber,
                    Type = model.Type,
                    Balance = model.Balance,
                    InterestRate = model.InterestRate,
                    Income = model.Income,
                    Term = model.Term,
                    PortfolioId = model.PortfolioId
                };

                _context.Loans.Add(loan);
                _context.SaveChanges();

                return Ok(loan);
            }

            return Ok(model);
        }

        [HttpPost]
        public IActionResult Edit([FromBody]Loan model)
        {
            if (ModelState.IsValid)
            {
                Loan loan = _context.Loans.Find(model.Id);

                if (loan != null)
                {
                    loan.AccountNumber = model.AccountNumber;
                    loan.Type = model.Type;
                    loan.Balance = model.Balance;
                    loan.InterestRate = model.InterestRate;
                    loan.Income = model.Income;
                    loan.PortfolioId = model.PortfolioId;
                    loan.Term = model.Term;

                    _context.Loans.Add(loan);
                    _context.SaveChanges();
                    return Ok(loan);
                }
            }

            return Ok(model);
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            if (id != null)
            {
                Loan loan = _context.Loans.Find(id);

                _context.Loans.Remove(loan);
                _context.SaveChanges();

                return Ok(loan);
            }

            return RedirectToAction("Index");
        }
    }
}
