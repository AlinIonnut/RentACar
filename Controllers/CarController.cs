using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.DTOs;
using RentACar.Services.CarService;

namespace RentACar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]

        public async Task<ActionResult<List<CarCreateDto>>> GetAllCars()
        {
            var cars = await _carService.GetAllCars();
            return Ok(cars);
        }

        [HttpGet("search")]

        public async Task<ActionResult<List<CarCreateDto>>> SearchCars(DateTime startDate, DateTime endDate)
        {
            var cars = await _carService.SearchCars(startDate, endDate);
            return Ok(cars);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<CarCreateDto>> GetCarById(int id)
        {
            var car = await _carService.GetCarById(id);
            if (car == null)
                return NotFound("Car was not found!");

            return Ok(car);
        }

        [HttpPost]

        public async Task<ActionResult<List<CarCreateDto>>> CreateCar(CarCreateDto request)
        {
            var car = await _carService.CreateCar(request);
            return Ok(car);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<CarCreateDto>>> UpdateCar(int id, CarCreateDto request)
        {
            var car = await _carService.UpdateCar(id, request);
            if (car == null)
                return NotFound("The car was not found!");
            return Ok(car);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<CarCreateDto>>> DeleteCar(int id)
        {
            var car = await _carService.DeleteCar(id);
            if (car == null)
                return NotFound("The car was not found!");
            return Ok(car);
        }
    }
}
