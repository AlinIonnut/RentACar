using RentACar.DTOs;
using RentACar.Models;

namespace RentACar.Repository.CarRepository
{
    public interface ICarRepository
    {
        Task<List<Car>> GetAllCars();

        Task<List<Car>> SearchCars(DateTime startDate, DateTime endDate);

        Task<Car> GetCarById(int id);

        Task<List<Car>> CreateCar(CarCreateDto request);

        Task<List<Car>> UpdateCar(int id, CarCreateDto request);

        Task<List<Car>> DeleteCar(int id);
    }
}
