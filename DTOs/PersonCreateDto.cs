using RentACar.Models;
using System.Text.Json.Serialization;

namespace RentACar.DTOs
{
    public class PersonCreateDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("genderType")]
        public GenderType GenderType { get; set; }

        [JsonPropertyName("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("prefix")]
        public string Prefix { get; set; }

        [JsonPropertyName("countryCode")]
       public string? CountryCode { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("rentals")]
        public List<Rental>? Rentals { get; set; }
    }
}
