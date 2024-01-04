using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using RentACar.DTOs;
using RentACar.Repository.PersonRepository;

namespace RentACar.Services.PersonService
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        
        public async Task<List<PersonCreateDto>> GetAllPersons()
        {
            var person = await _personRepository.GetAllPersons();
            var result = _mapper.Map<List<PersonCreateDto>>(person);
            return result;
        }

        public async Task<PersonCreateDto> GetOnePerson(int id)
        {
            var person = await _personRepository.GetOnePerson(id);
            var result = _mapper.Map<PersonCreateDto>(person);
            return result;
        }
        public async Task<List<PersonCreateDto>> CreatePerson(PersonCreateDto request)
        {
            var person = await _personRepository.CreatePerson(request);
            var result = _mapper.Map<List<PersonCreateDto>>(person);
            return result;
        }

        public async Task<List<PersonCreateDto>> UpdatePerson(int id, PersonCreateDto request)
        {
            var person = await _personRepository.UpdatePerson(id, request);
            var result = _mapper.Map<List<PersonCreateDto>>(person);
            return result;
        }
        public async Task<List<PersonCreateDto>> DeletePerson(int id)
        {
            try
            {
                var person = await _personRepository.DeletePerson(id);
                var result = _mapper.Map<List<PersonCreateDto>>(person);
                return result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
