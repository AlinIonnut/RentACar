using AutoMapper;
using RentACar.DTOs;
using RentACar.Repository.CarRepository;

namespace RentACar.Services.CarService
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper= mapper;
        }

        public async Task<List<CarCreateDto>> GetAllCars()
        {
            var cars = await _carRepository.GetAllCars();
            var result = _mapper.Map<List<CarCreateDto>>(cars);
            return result;
        }

        public async Task<List<CarCreateDto>> SearchCars(DateTime startDate, DateTime endDate)
        {
            var car = await _carRepository.SearchCars(startDate, endDate);
            var result = _mapper.Map<List<CarCreateDto>>(car);
            return result;
        }

        public async Task<CarCreateDto> GetCarById(int id)
        {
            var car = await _carRepository.GetCarById(id);
            var result = _mapper.Map<CarCreateDto>(car);
            return result;
        }
        public async Task<List<CarCreateDto>> CreateCar(CarCreateDto request)
        {
            var car = await _carRepository.CreateCar(request);
            var result = _mapper.Map<List<CarCreateDto>>(car);
            return result;
        }

        public async Task<List<CarCreateDto>> UpdateCar(int id, CarCreateDto request)
        {
            var car = await _carRepository.UpdateCar(id, request);
            var result = _mapper.Map<List<CarCreateDto>>(car);
            return result;
        }

        public async Task<List<CarCreateDto>> DeleteCar(int id)
        {
            var car = await _carRepository.DeleteCar(id);
            var result = _mapper.Map<List<CarCreateDto>>(car);
            return result;
        }
    }
}
