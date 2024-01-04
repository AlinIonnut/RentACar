using RentACar.DTOs;
using AutoMapper;
using RentACar.Repository.RentalRepository;

namespace RentACar.Services.RentalService
{
    public class RentalService : IRentalService
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IMapper _mapper;

        public RentalService(IRentalRepository rentalRepository, IMapper mapper)
        {
            _rentalRepository = rentalRepository;
            _mapper = mapper;
        }

        public async Task<List<RentalCreateDto>> GetAllRents()
        {
            var rental = await _rentalRepository.GetAllRents();
            var result = _mapper.Map<List<RentalCreateDto>> (rental);
            return result;
        }

        public async Task<RentalCreateDto> GetOneRental(int id)
        {
            var rental = await _rentalRepository.GetOneRental(id);
            var result = _mapper.Map<RentalCreateDto>(rental);
            return result;
        }
        public async Task<List<RentalCreateDto>> CreateRental(RentalCreateDto request)
        {
            var rental = await _rentalRepository.CreateRental(request);
            var result = _mapper.Map<List<RentalCreateDto>> (rental);
            return result;
        }

        public async Task<List<RentalCreateDto>> UpdateRental(int id, RentalCreateDto request)
        {
            var rental = await _rentalRepository.UpdateRental(id, request);
            var result = _mapper.Map<List<RentalCreateDto>>(rental);
            return result;
        }

        public async Task<List<RentalCreateDto>> DeleteRental(int id)
        {
            var rental = await _rentalRepository.DeleteRental(id);
            var result = _mapper.Map<List<RentalCreateDto>>(rental);
            return result;
        }
    }
}
