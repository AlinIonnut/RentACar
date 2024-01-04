using RentACar.Models;
using System.Text.Json.Serialization;

namespace RentACar.DTOs
{
    public class CarCreateDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonPropertyName("picture")]
        public byte[]? Picture { get; set; }

        [JsonPropertyName("gearboxType")]
        public GearboxType GearboxType { get; set; }

        [JsonPropertyName("carType")]
        public CarType CarType { get; set; }

        [JsonPropertyName("transmissionType")]
        public TransmissionType TransmissionType { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("registrationNumber")]
        public string RegistrationNumber { get; set; }

        [JsonPropertyName("power")]
        public int Power { get; set; }

        [JsonPropertyName("combustibleType")]
        public CombustibleType CombustibleType { get; set; }

        [JsonPropertyName("seats")]
        public int Seats { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("rentals")]
        public List<RentalCreateDto>? Rentals { get; set; }
    }
}
