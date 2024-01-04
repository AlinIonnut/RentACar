using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.DTOs;
using RentACar.Services.RentalService;

namespace RentACar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IRentalService _rentalService;

        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet]

        public async Task<ActionResult<List<RentalCreateDto>>> GetAllRents()
        {
            var rental = await _rentalService.GetAllRents();
            return Ok(rental);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<RentalCreateDto>> GetOneRental(int id) // aici nu este List<>
        {
            var rental = await _rentalService.GetOneRental(id);
            if (rental == null)
                return NotFound("The rental was not found!");
            return Ok(rental);
        }

        [HttpPost]

        public async Task<ActionResult<List<RentalCreateDto>>> CreateRental(RentalCreateDto request)
        {
            var rental = await _rentalService.CreateRental(request);
            return Ok(rental);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<RentalCreateDto>>> UpdateRental(int id, RentalCreateDto request)
        {
            var rental = await _rentalService.UpdateRental(id, request);
            if (rental is null)
                return NotFound("The rental was not found!");
            return Ok(rental);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<RentalCreateDto>>> DeleteRental(int id)
        {
            var rental = await _rentalService.DeleteRental(id);
            if (rental is null)
                return NotFound("The rental was not found!");
            return Ok(rental);
        }
    }
}
