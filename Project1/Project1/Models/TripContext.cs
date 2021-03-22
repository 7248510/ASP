using Microsoft.EntityFrameworkCore; //Adding the namespace

namespace Project1.Models
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options)
            : base(options)
        { }
        public DbSet<Trip> Trips { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //Random data. I couldn't get the table to present itself
            modelBuilder.Entity<Trip>().HasData(
                new Trip {TripId = 1, Destination = "USA", startDate = "04/12/2001", endDate = "04/12/2099", Accommodation = "", AccommodationPhone = "", AccommodationEmail = "",
                ThingToDo1 = "",
                ThingToDo2 = "",
                ThingToDo3 = ""
                },
                new Trip
                {
                    TripId = 2,
                    Destination = "CA",
                    startDate = "05/28/1698",
                    endDate = "05/28/1468",
                    Accommodation = "",
                    AccommodationPhone = "",
                    AccommodationEmail = "",
                    ThingToDo1 = "",
                    ThingToDo2 = "",
                    ThingToDo3 = ""
                },
                new Trip
                {
                    TripId = 3,
                    Destination = "NZ",
                    startDate = "19/79/1987",
                    endDate = "19/79/2079",
                    Accommodation = "",
                    AccommodationPhone = "",
                    AccommodationEmail = "",
                    ThingToDo1 = "",
                    ThingToDo2 = "",
                    ThingToDo3 = ""
                }

                );
        }
    }
}
