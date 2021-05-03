using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;
namespace ClassSchedule.Components
{
    public class DayFilter : ViewComponent
    {
        private IRepository<Day> data { get; set; } //dependency injection IRepo
        public DayFilter(IRepository<Day> rep) => data = rep; //Getting ready to query
        public IViewComponentResult Invoke()
        {
            var days = data.List(new QueryOptions<Day>
            {
                OrderBy = d => d.DayId //Order by the day's ID
            });
            return View(days); //Return IViewComponentResult, this links to the partial view
        }
    }
}