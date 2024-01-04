using RentACar.DTOs;
using System.Text.Json.Serialization;

namespace RentACar.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public GenderType GenderType { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? PhoneNumber { get; set; }

        public string Prefix { get; set; }

        public string? CountryCode { get; set; }

        public string Number { get; set; }

        public string Email { get; set; }
        
        public List<RentalCreateDto>? Rentals { get; set; }

    }
}
