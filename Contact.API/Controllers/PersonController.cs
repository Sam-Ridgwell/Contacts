using Microsoft.AspNetCore.Mvc;
using Contact.Application.Services.Interfaces;
using Contact.Application.ApiRepository.ApiObjects;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_personService.GetPersonById(1));
        }

        [HttpGet("{id}")]
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
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Post(PersonApo person)
        {
            if (_personService.AddPerson(person))
            {
                return Created("api/person", _personService.AddPerson(person));
            }

            return StatusCode(500);
        }

    }
}
