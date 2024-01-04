using Microsoft.EntityFrameworkCore;
using RentACar.Models;

namespace RentACar.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Rental> Rentals { get; set; }
    }
}
