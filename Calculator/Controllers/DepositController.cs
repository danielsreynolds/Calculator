using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    public class DepositController : Controller
    {
        private readonly AppDBContext _context;

        public DepositController(AppDBContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index(string id)
        {
            if (id != null)
            {
                return RedirectToAction("Details", new { id });
            };

            return Ok(_context.Deposits);
        }

        public IActionResult Details(string id)
        {
            if (id != null)
            {
                return Ok(_context.Deposits.Find(id));
            };

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create([FromBody]Deposit model)
        {
            if (ModelState.IsValid)
            {
                Deposit deposit = new Deposit
                {
                    AccountNumber = model.AccountNumber,
                    Type = model.Type,
                    InterestRate = model.InterestRate,
                    PortfolioId = model.PortfolioId,
                    AverageBalance = model.AverageBalance,
                    Cost = model.Cost
                };

                _context.Deposits.Add(deposit);
                _context.SaveChanges();

                return Ok(deposit);
            }

            return Ok(model);
        }

        [HttpPost]
        public IActionResult Edit([FromBody]Deposit model)
        {
            if (ModelState.IsValid)
            {
                Deposit deposit = _context.Deposits.Find(model.Id);

                if (deposit != null)
                {
                    deposit.AccountNumber = model.AccountNumber;
                    deposit.Type = model.Type;
                    deposit.AverageBalance = model.AverageBalance;
                    deposit.InterestRate = model.InterestRate;
                    deposit.PortfolioId = model.PortfolioId;
                    deposit.Cost = model.Cost;

                    var depositUpdate = _context.Deposits.Attach(deposit);
                    depositUpdate.State = EntityState.Modified;
                    _context.SaveChanges();

                    return Ok(deposit);
                }
            }

            return Ok(model);
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            if (id != null)
            {
                Deposit deposit = _context.Deposits.Find(id);
                _context.Deposits.Remove(deposit);
                _context.SaveChanges();

                return Ok(deposit);
            }

            return RedirectToAction("Index");
        }
    }
}
