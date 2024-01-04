using RentACar.DTOs;

namespace RentACar.Services.PersonService
{
    public interface IPersonService
    {
        Task<List<PersonCreateDto>> GetAllPersons();

        Task<PersonCreateDto> GetOnePerson(int id);

        Task<List<PersonCreateDto>> CreatePerson(PersonCreateDto request);

        Task<List<PersonCreateDto>> UpdatePerson(int id, PersonCreateDto request);

        Task<List<PersonCreateDto>> DeletePerson(int id);
    }
}
