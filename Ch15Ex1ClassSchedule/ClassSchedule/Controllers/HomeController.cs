using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;

namespace ClassSchedule.Controllers
{
    //Removed all unnecessary lines
    public class HomeController : Controller
    {
        private IRepository<Class> data { get; set; }
        public HomeController(IRepository<Class> rep) => data = rep;
        public ViewResult Index(int id)
        {
            var classOptions = new QueryOptions<Class>
            {
                Includes = "Teacher, Day"
            };
            if (id == 0)
            {classOptions.OrderBy = c => c.DayId;} //Order by the classes since no ID is supplied
            else
            {
                classOptions.Where = c => c.DayId == id;
                classOptions.OrderBy = c => c.MilitaryTime;
            }
            return View(data.List(classOptions));
        }
    }
}