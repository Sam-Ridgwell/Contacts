using Microsoft.AspNetCore.Mvc;
using Contact.Application.Person;
using Contact.Domain.DataObjects;

namespace Contact.API.Controllers
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var result = _personService.GetPersonById(1);

            if (!result.IsSuccess())
            {
                return StatusCode(500);
            }

            return Ok(_personService.GetPersonById(1).GetValue());
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            if (id == 1)
            {
                return Ok(new { Name = "John Doe" });
            }

            return NotFound();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(PersonDto person)
        {
            var result = _personService.AddPerson(person);


            if (result.IsSuccess())
            {
                return Created("api/person", _personService.AddPerson(person));
            }

            return StatusCode(400, result.GetException()?.Message);
        }
    }
}
