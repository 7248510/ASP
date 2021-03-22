using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace TripController.Controllers
{
    public class TripController : Controller
    {
        private TripContext context { get; set; }

        public TripController(TripContext ctx)
        {
            context = ctx;
   
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            //ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
            return View("Page2");
        }

        [HttpGet]
        public IActionResult Page2()
        {
            ViewBag.Action = "Add";
            //ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
            return View("Page3"); //Passes data
        }

        [HttpGet]
        public IActionResult Page3()
        {
            //ViewBag.Action = "Add";
            //ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
            return View("Index"); //Save?
        }
    }
}