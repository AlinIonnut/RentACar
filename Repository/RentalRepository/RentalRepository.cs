using RentACar.DTOs;
using RentACar.Models;
using RentACar.Data;
using Microsoft.EntityFrameworkCore;

namespace RentACar.Repository.RentalRepository
{
    public class RentalRepository : IRentalRepository
    {
        private readonly DataContext _dbContext;

        public RentalRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Rental>> GetAllRents()
        {
            var rental = await _dbContext.Rentals.ToListAsync();
            if (rental is null || rental.Count == 0)
            {
                return null;
            }
            else
            {
                return rental;
            }
        }

        public async Task<Rental> GetOneRental(int id)
        {
            var rental = await _dbContext.Rentals.FirstOrDefaultAsync(r => r.Id == id);
            if (rental is null)
                return null;
            return rental;
        }

        public async Task<List<Rental>> CreateRental(RentalCreateDto request)
        {
            var car = await _dbContext.Cars.FirstOrDefaultAsync(c => c.Id == request.CarId);
            if (car == null)
            {
                return null;
            }
            var numberOfDays = (int)(request.EndDate - request.StartDate).TotalDays;
            var totalPrice = numberOfDays * car.Price;

            var newRental = new Rental
            {   
                CarId = request.CarId,
                PersonId = request.PersonId,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                PickUpTime = request.PickUpTime,
                DropOfTime = request.DropOfTime,
                PickUpLocation = request.PickUpLocation,
                DropOfLocation = request.DropOfLocation,
                TotalPrice = totalPrice,
            };

            _dbContext.Rentals.Add(newRental);
            await _dbContext.SaveChangesAsync();

            return await _dbContext.Rentals.ToListAsync();
        }

        public async Task<List<Rental>> UpdateRental(int id, RentalCreateDto request)
        {
            var rental = await _dbContext.Rentals.FirstOrDefaultAsync(r => r.Id == id);
            if (rental is null)
                return null;


            if (rental.StartDate != request.StartDate || rental.EndDate != request.EndDate)
            {
                var car = await _dbContext.Cars.FirstOrDefaultAsync(c => c.Id == request.CarId);
                if (car == null)
                {
                    return null;
                }
                var numberOfDays = (int)(request.EndDate - request.StartDate).TotalDays;
                rental.TotalPrice = numberOfDays * car.Price;
            }

            rental.CarId = request.CarId;
            rental.PersonId = request.PersonId;
            rental.StartDate = request.StartDate;
            rental.EndDate = request.EndDate;
            rental.PickUpTime = request.PickUpTime;
            rental.DropOfTime = request.DropOfTime;
            rental.PickUpLocation = request.PickUpLocation;
            rental.DropOfLocation = request.DropOfLocation;

            await _dbContext.SaveChangesAsync();

            return await _dbContext.Rentals.ToListAsync();
        }
        public async Task<List<Rental>> DeleteRental(int id)
        {
            var rental = await _dbContext.Rentals.FirstOrDefaultAsync(r => r.Id == id);
            if (rental is null)
                return null;

            _dbContext.Remove(rental);
            await _dbContext.SaveChangesAsync();

            var remainingRentals = await _dbContext.Rentals.ToListAsync();
            return remainingRentals;
        }
    }
}
