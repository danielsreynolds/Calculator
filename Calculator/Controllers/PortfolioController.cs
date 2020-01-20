using System;
using System.Linq;
using Calculator.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Calculator.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDBContext _context;


        public PortfolioController(AppDBContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index(string id)
        {
            if (id != null)
            {
                return RedirectToAction("Details", new { id });
            };

            return Ok(_context.Portfolios);
        }

        public IActionResult Details(string id)
        {
            if (id != null)
            {
                Portfolio portfolio = _context.Portfolios
                    .Include(p => p.Loans)
                    .Include(p => p.CertificateOfDeposits)
                    .Include(p => p.CreditCards)
                    .Include(p => p.Deposits)
                    .FirstOrDefault(p => p.Id == id);

                return Ok(portfolio);
            };

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create([FromBody]Portfolio model)
        {
            if (ModelState.IsValid)
            {
                Portfolio portfolio = new Portfolio
                {
                    Name = model.Name,
                    Type = model.Type
                };

                _context.Portfolios.Add(portfolio);
                _context.SaveChanges();

                return Ok(portfolio);
            }

            return Ok(model);
        }

        [HttpPost]
        public IActionResult Edit([FromBody]Portfolio model)
        {
            if (ModelState.IsValid)
            {
                Portfolio portfolio = _context.Portfolios.Find(model.Id);

                if (portfolio != null)
                {
                    portfolio.Name = model.Name;
                    portfolio.Type = model.Type;

                    var portfolioUpdate = _context.Portfolios.Attach(portfolio);
                    portfolioUpdate.State = EntityState.Modified;
                    _context.SaveChanges();

                    return Ok(portfolio);
                }
            }

            return Ok(model);
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            if (id != null)
            {
                Portfolio portfolio = _context.Portfolios.Find(id);
                _context.Portfolios.Remove(portfolio);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}