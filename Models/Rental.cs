using System.Text.Json.Serialization;

namespace RentACar.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int PersonId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan PickUpTime { get; set; }

        public TimeSpan DropOfTime { get; set; }

        public string PickUpLocation { get; set; }

        public string DropOfLocation { get; set; }

        public int TotalPrice { get; set; }

        public Car? Car { get; set; }

        public Person? Person { get; set; }
    }
}
