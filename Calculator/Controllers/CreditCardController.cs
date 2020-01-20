using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Calculator.Controllers
{
    public class CreditCardController : Controller
    {
        private readonly AppDBContext _context;

        public CreditCardController(AppDBContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index(string id)
        {
            if (id != null)
            {
                return RedirectToAction("Details", new { id });
            };

            return Ok(_context.CreditCards);
        }

        public IActionResult Details(string id)
        {
            if (id != null)
            {
                return Ok(_context.CreditCards.Find(id));
            };

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create([FromBody]CreditCard model)
        {
            if (ModelState.IsValid)
            {
                CreditCard creditCard = new CreditCard
                {
                    AccountNumber = model.AccountNumber,
                    Type = model.Type,
                    Balance = model.Balance,
                    InterestRate = model.InterestRate,
                    Income = model.Income,
                    UsageByPercentage = model.UsageByPercentage,
                    PortfolioId = model.PortfolioId
                };

                _context.CreditCards.Add(creditCard);
                _context.SaveChanges();

                return Ok(creditCard);
            }

            return Ok(model);
        }

        [HttpPost]
        public IActionResult Edit([FromBody]CreditCard model)
        {
            if (ModelState.IsValid)
            {
                CreditCard creditCard = _context.CreditCards.Find(model.Id);

                if (creditCard != null)
                {
                    creditCard.AccountNumber = model.AccountNumber;
                    creditCard.Type = model.Type;
                    creditCard.Balance = model.Balance;
                    creditCard.InterestRate = model.InterestRate;
                    creditCard.Income = model.Income;
                    creditCard.UsageByPercentage = model.UsageByPercentage;
                    creditCard.PortfolioId = model.PortfolioId;

                    var creditCardUpdate = _context.CreditCards.Attach(creditCard);
                    creditCardUpdate.State = EntityState.Modified;
                    _context.SaveChanges();

                    return Ok(creditCard);
                }
            }

            return Ok(model);
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            if (id != null)
            {
                CreditCard creditCard = _context.CreditCards.Find(id);
                _context.CreditCards.Remove(creditCard);
                _context.SaveChanges();

                return Ok(creditCard);
            }

            return RedirectToAction("Index");
        }
    }
}