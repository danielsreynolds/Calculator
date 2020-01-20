using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    public class CertificateOfDepositController : Controller
    {
        private readonly AppDBContext _context;

        public CertificateOfDepositController(AppDBContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index(string id)
        {
            if (id != null)
            {
                return RedirectToAction("Details", new { id });
            };

            return Ok(_context.CertificateOfDeposits);
        }

        public IActionResult Details(string id)
        {
            if (id != null)
            {
                return Ok(_context.CertificateOfDeposits.Find(id));
            };

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create([FromBody]CertificateOfDeposit model)
        {
            if (ModelState.IsValid)
            {
                CertificateOfDeposit certificateOfDeposit = new CertificateOfDeposit
                {
                    AccountNumber = model.AccountNumber,
                    Type = model.Type,
                    Term = model.Term,
                    InterestRate = model.InterestRate,
                    PortfolioId = model.PortfolioId
                };

                _context.CertificateOfDeposits.Add(certificateOfDeposit);
                _context.SaveChanges();

                return Ok(certificateOfDeposit);
            }

            return Ok(model);
        }

        [HttpPost]
        public IActionResult Edit([FromBody]CertificateOfDeposit model)
        {
            if (ModelState.IsValid)
            {
                CertificateOfDeposit certificateOfDeposit = _context.CertificateOfDeposits.Find(model.Id);

                if (certificateOfDeposit != null)
                {
                    certificateOfDeposit.AccountNumber = model.AccountNumber;
                    certificateOfDeposit.Type = model.Type;
                    certificateOfDeposit.Term = model.Term;
                    certificateOfDeposit.InterestRate = model.InterestRate;

                    var certificateOfDepositUpdate = _context.CertificateOfDeposits.Attach(certificateOfDeposit);
                    certificateOfDepositUpdate.State = EntityState.Modified;
                    _context.SaveChanges();

                    return Ok(certificateOfDeposit);
                }
            }

            return Ok(model);
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            if (id != null)
            {
                CertificateOfDeposit certificateOfDeposit = _context.CertificateOfDeposits.Find(id);
                _context.CertificateOfDeposits.Remove(certificateOfDeposit);
                _context.SaveChanges();

                return Ok(certificateOfDeposit);
            }

            return RedirectToAction("Index");
        }
    }
}
