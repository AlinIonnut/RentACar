using RentACar.DTOs;
using RentACar.Models;

namespace RentACar.Repository.PersonRepository
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllPersons();

        Task<Person> GetOnePerson(int id);

        Task<List<Person>> CreatePerson(PersonCreateDto request);

        Task<List<Person>> UpdatePerson(int id, PersonCreateDto request);

        Task<List<Person>> DeletePerson(int id);
    }
}
