using Contact.Domain.Person.DataObjects;
using Contact.Domain.Person.Services;
using Contact.Domain.Person.Validators;
using Contacts.Core;
using FluentValidation;

namespace Contact.Application.Person
{
    public class PersonService : IPersonService
    {
        private readonly IPersonDataService _personDataService;

        public PersonService(IPersonDataService personDataService)
        {
            _personDataService = personDataService;
        }

        public Result<bool> AddPerson(PersonDto personApo)
        {
            var person = new Domain.Person.Entities.Person(personApo.Name);

            PersonValidator personValidator = new();

            var personIsValid = personValidator.Validate(person);

            if (!personIsValid.IsValid)
            {
                return new Result<bool>(new ValidationException(personIsValid.Errors));
            }

            return _personDataService.AddPerson(new PersonDto(person.Name));
        }

        public Result<PersonDto> GetPersonById(int id)
        {
            return new Result<PersonDto>(_personDataService.GetPersonById(id));
        }
    }
}