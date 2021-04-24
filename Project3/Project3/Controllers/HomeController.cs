using Microsoft.AspNetCore.Mvc;
using Project3.Models;
using Project3.Controllers;

namespace Project3.Controllers
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
