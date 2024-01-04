using RentACar.Data;
using RentACar.DTOs;
using RentACar.Models;
using Microsoft.EntityFrameworkCore;

namespace RentACar.Repository.PersonRepository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext _dbContext;

        public PersonRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Person>> GetAllPersons()
        {
            var person = await _dbContext.Persons.ToListAsync();
            if(person is null || person.Count == 0)
            {
                return null;
            }
            else
            {
                return person;
            }
        }

        public async Task<Person> GetOnePerson(int id)
        {
            var person = await _dbContext.Persons.FirstOrDefaultAsync(person => person.Id == id);
            if (person is null)
                return null;
            return person;
        }
        public async Task<List<Person>> CreatePerson(PersonCreateDto request)
        {
            var newPerson = new Person
            {
                Name = request.Name,
                GenderType = request.GenderType,
                DateOfBirth = request.DateOfBirth,
              //  PhoneNumber = request.PhoneNumber,
                Prefix = request.Prefix,
               // CountryCode = request.CountryCode,
                Number = request.Number,
                Email = request.Email
            };


            _dbContext.Persons.Add(newPerson);
            await _dbContext.SaveChangesAsync();

            return await _dbContext.Persons.ToListAsync();
        }

        public async Task<List<Person>> UpdatePerson(int id, PersonCreateDto request)
        {
            var person = await _dbContext.Persons.FirstOrDefaultAsync(person=>person.Id == id);
            if (person is null)
                return null;

            person.Name = request.Name;
            person.GenderType = request.GenderType;
            person.DateOfBirth = request.DateOfBirth;
          //  person.PhoneNumber = request.PhoneNumber;
            person.Prefix = request.Prefix;
         //   person.CountryCode = request.CountryCode;
            person.Number = request.Number;
            person.Email = request.Email;
            


            await _dbContext.SaveChangesAsync();

            return await _dbContext.Persons.ToListAsync();
        }
        public async Task<List<Person>> DeletePerson(int id)
        {
            var person = await _dbContext.Persons.FirstOrDefaultAsync(person => person.Id == id);
            if (person is null)
                return null;

            _dbContext.Persons.Remove(person);
            await _dbContext.SaveChangesAsync();

            var remainingPersons = await _dbContext.Persons.ToListAsync();
            return remainingPersons;
        }
    }
}
