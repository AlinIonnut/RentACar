using RentACar.DTOs;

namespace RentACar.Services.RentalService
{
    public interface IRentalService
    {
        Task<List<RentalCreateDto>> GetAllRents();

        Task<RentalCreateDto> GetOneRental(int id);

        Task<List<RentalCreateDto>> CreateRental(RentalCreateDto request);

        Task<List<RentalCreateDto>> UpdateRental(int id, RentalCreateDto response);

        Task<List<RentalCreateDto>> DeleteRental(int id);
    }
}
