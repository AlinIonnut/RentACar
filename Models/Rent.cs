namespace RentACar.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan PickUpTime { get; set; }

        public TimeSpan DropOfTime { get; set; }

        public string PickUpLocation { get; set; }

        public string DropOfLocation { get; set; } 

        public int TotalPrice { get; set; }

        public List<Car> Cars { get; set; }

        public List<Person> Persons { get; set; }
    }
}
