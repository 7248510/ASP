using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Home");
        }

        public IActionResult Privacy()
        {
            return Content("Privacy");
        }

        public IActionResult Display(string id)
        {
            if (id == null)
            {
                return Content("No ID supplied.");
            }
            else
            {
                return Content("ID: " + id);
            }
        }
        [Route("[action]/{start}/{end?}/{message?}")] //Segment name must match the parameter
        public IActionResult Countdown(int start, int end = 0, string message = "")
        //public IActionResult Countdown(int id= 0) //without routing
        {
            string contentString = "Counting down:\n";
            for (int i = start; i >= end; i--) //i starts at start and has to be less than the end 
            {
                contentString += i + "\n";
            }
            contentString += message; //Appends the message value
            return Content(contentString);
        }
    }
}
