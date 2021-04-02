using Microsoft.AspNetCore.Mvc;
using Project2.Models;
using Project2.Controllers;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            ViewBag.discountPercent = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(quotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.calculateSales();
                ViewBag.discountPercent = model.discountamount(ViewBag.FV);
            }
            else
            {
                ViewBag.FV = 0;
                ViewBag.discountPercent = 0;
            }
            return View(model);
        }

    }
}
