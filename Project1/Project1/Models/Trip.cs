using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Project1.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        [Required(ErrorMessage = "Please enter a destination.")]
        public string Destination { get; set; }
        [Required(ErrorMessage = "Please enter a start date.")]
        public string startDate { get; set; }
        [Required(ErrorMessage = "Please enter a end date.")]
        public string endDate { get; set; }
        //End Required
        [Required(ErrorMessage = "Please enter a destination.")]
        public string Accommodation { get; set; }
        public string AccommodationPhone { get; set; }
        public string AccommodationEmail { get; set; }
        public string ThingToDo1 { get; set; } //Things to do
        public string ThingToDo2 { get; set; } //Things to do
        public string ThingToDo3 { get; set; } //Things to do
        //public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}
