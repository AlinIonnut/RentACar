using Microsoft.EntityFrameworkCore;
using RentACar.Models;

namespace BlazorRental.Models
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Rental> Rentals { get; set; }
    }
}
