using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        private TripContext context { get; set; }

        public HomeController(TripContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
