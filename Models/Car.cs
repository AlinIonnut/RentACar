using RentACar.DTOs;
using System.Text.Json.Serialization;

namespace RentACar.Models
{
    public class Car
    {
        public int Id { get; set; }

        public bool IsEnabled { get; set; }

        public byte[]? Picture { get; set; }

        public GearboxType GearboxType { get; set; }

        public CarType CarType { get; set; }

        public TransmissionType TransmissionType { get; set; }

        public string Brand { get; set; }

        public string RegistrationNumber { get; set; }

        public int Power { get; set; }

        public CombustibleType CombustibleType { get; set; }

        public int Seats { get; set; }

        public int Price { get; set; }

        public List<Rental>? Rentals { get; set; }
    }
}
