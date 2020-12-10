using Microsoft.AspNetCore.Mvc;
using LoanCalculator.Models;

namespace LoanCalculator.Controllers
{
    public class CreditController : Controller
    {
        [HttpGet]
        public IActionResult GetCredit(Credit credit)
        {
            return View(credit);
        }

        [HttpPost]
        public IActionResult SetCredit(Credit credit)
        {

            credit.SetTotalSum();

           return RedirectToAction("GetCredit", credit);
        }
    }
}
