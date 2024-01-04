using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Services.PersonService;
using RentACar.DTOs;


namespace RentACar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]

        public async Task<ActionResult<List<PersonCreateDto>>> GetAllPersons()
        {
            var persons = await _personService.GetAllPersons();
            return Ok(persons);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<PersonCreateDto>> GetOnePerson(int id)
        {
            var person = await _personService.GetOnePerson(id);
            if (person is null)
                return NotFound("The person was not found!");
            return Ok(person);
        }

        [HttpPost]

        public async Task<ActionResult<List<PersonCreateDto>>> CreatePerson(PersonCreateDto request)
        {
            var person = await _personService.CreatePerson(request);
            return Ok(person);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<PersonCreateDto>>> UpdatePerson(int id, PersonCreateDto request)
        {
            var person = await _personService.UpdatePerson(id, request);
            if (person == null)
                return NotFound("The person was not found!");
            return Ok(person);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<PersonCreateDto>>> DeletePerson(int id)
        {
            var person = await _personService.DeletePerson(id);
            if (person == null)
                return NotFound("The person was not found!");
            return Ok(person);
        }
    }
}
