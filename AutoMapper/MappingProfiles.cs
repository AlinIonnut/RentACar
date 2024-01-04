using RentACar.Models;
using AutoMapper;
using RentACar.DTOs;

namespace RentACar.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Car, CarCreateDto>();
            CreateMap<CarCreateDto, Car>();
            CreateMap<Person, PersonCreateDto>();
            CreateMap<PersonCreateDto, Person>();
            CreateMap<Rental, RentalCreateDto>();
            CreateMap<RentalCreateDto, Rental>();
        }
    }
}
