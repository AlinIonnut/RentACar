using RentACar.DTOs;
using RentACar.Models;

namespace RentACar.Repository.RentalRepository
{
    public interface IRentalRepository
    {
        Task<List<Rental>> GetAllRents();

        Task<Rental> GetOneRental(int id);

        Task<List<Rental>> CreateRental(RentalCreateDto request);

        Task<List<Rental>> UpdateRental(int id, RentalCreateDto response);

        Task<List<Rental>> DeleteRental(int id);
    }
}
