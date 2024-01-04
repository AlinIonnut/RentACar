using RentACar.Models;
using System.Text.Json.Serialization;

namespace RentACar.DTOs
{
    public class RentalCreateDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("carId")]
        public int CarId { get; set; }

        [JsonPropertyName("personId")]
        public int PersonId { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("pickUpTime")]
        public TimeSpan PickUpTime { get; set; }

        [JsonPropertyName("dropOfTime")]
        public TimeSpan DropOfTime { get; set; }

        [JsonPropertyName("pickUpLocation")]
        public string PickUpLocation { get; set; }

        [JsonPropertyName("dropOfLocation")]
        public string DropOfLocation { get; set; }

        [JsonPropertyName("totalPrice")]
        public int TotalPrice { get; set; }

        [JsonPropertyName("car")]
        public Car? Car { get; set; }

        [JsonPropertyName("person")]
        public Person? Person { get; set; }
    }
}
