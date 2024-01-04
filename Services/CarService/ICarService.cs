using RentACar.DTOs;

namespace RentACar.Services.CarService
{
    public interface ICarService
    {
        Task<List<CarCreateDto>> GetAllCars();

        Task<List<CarCreateDto>> SearchCars(DateTime startDate, DateTime endDate);

        Task<CarCreateDto> GetCarById(int id);

        Task<List<CarCreateDto>> CreateCar(CarCreateDto request);

        Task<List<CarCreateDto>> UpdateCar(int id, CarCreateDto request);

        Task<List<CarCreateDto>> DeleteCar(int id);
    }
}
