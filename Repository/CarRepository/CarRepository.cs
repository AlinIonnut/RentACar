using RentACar.Data;
using RentACar.DTOs;
using RentACar.Models;
using Microsoft.EntityFrameworkCore;

namespace RentACar.Repository.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _dbContext;

        public CarRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Car>> GetAllCars()
        {
            var car = await _dbContext.Cars.ToListAsync();
            if (car is null || car.Count == 0)
            {
                return null;
            }
            else
            {
                return car;
            }
        }

        public async Task<List<Car>> SearchCars(DateTime startDate, DateTime endDate)
        {
            var test = await _dbContext.Cars.Include(x => x.Rentals).ToListAsync();
            var availabeCars = await _dbContext.Cars.Include(x => x.Rentals).Where(car => car.Rentals.All
            (rental => rental.EndDate <= startDate || rental.StartDate >= endDate)).ToListAsync();
            return availabeCars;
        }

        public async Task<Car> GetCarById(int id)
        {
            var car = await _dbContext.Cars.FirstOrDefaultAsync(car => car.Id == id);
            if (car is null) 
                return null;
            return car;
        }

        public async Task<List<Car>> CreateCar(CarCreateDto request)
        {
            var newCar = new Car
            {
                Brand = request.Brand,
                RegistrationNumber = request.RegistrationNumber,
                Picture = request.Picture,
                GearboxType = request.GearboxType,
                CarType = request.CarType,
                TransmissionType = request.TransmissionType,
                Power = request.Power,
                CombustibleType = request.CombustibleType,
                Seats = request.Seats,
                Price = request.Price
            };


            _dbContext.Cars.Add(newCar);
            await _dbContext.SaveChangesAsync();

            return await _dbContext.Cars.ToListAsync();
        }

        public async Task<List<Car>> UpdateCar(int id, CarCreateDto request)
        {
            var car = await _dbContext.Cars.FirstOrDefaultAsync(c => c.Id == id);
            if (car == null)
                return null;

            if (car.Price != request.Price)
            {
                car.Brand = request.Brand;
                car.RegistrationNumber = request.RegistrationNumber;
                car.Picture = request.Picture;
                car.GearboxType = request.GearboxType;
                car.CarType = request.CarType;
                car.TransmissionType = request.TransmissionType;
                car.Power = request.Power;
                car.CombustibleType = request.CombustibleType;
                car.Seats = request.Seats;
                car.Price = request.Price;

                // Recalculate TotalPrice for all rentals containing this car
                var rentalsToUpdate = await _dbContext.Rentals
                    .Where(r => r.CarId == id)
                    .ToListAsync();

                foreach (var rental in rentalsToUpdate)
                {
                    var numberOfDays = (int)(rental.EndDate - rental.StartDate).TotalDays;
                    rental.TotalPrice = numberOfDays * car.Price;
                }
            }
            else
            {
                car.Brand = request.Brand;
                car.RegistrationNumber = request.RegistrationNumber;
                car.Picture = request.Picture;
                car.GearboxType = request.GearboxType;
                car.CarType = request.CarType;
                car.TransmissionType = request.TransmissionType;
                car.Power = request.Power;
                car.CombustibleType = request.CombustibleType;
                car.Seats = request.Seats;
            }


            await _dbContext.SaveChangesAsync();

            return await _dbContext.Cars.ToListAsync();
        }
        public async Task<List<Car>> DeleteCar(int id)
        {
            var car = await _dbContext.Cars.FirstOrDefaultAsync(car => car.Id == id); 
            if (car is null)
                return null;

            _dbContext.Cars.Remove(car);
            await _dbContext.SaveChangesAsync();

            var remainingsCars = await _dbContext.Cars.ToListAsync();
            return remainingsCars;
        }
    }
}
