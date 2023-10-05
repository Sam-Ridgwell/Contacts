using Contact.Domain.DataObjects;
using Contacts.Core;

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
            throw new NotImplementedException();

            //var person = new Domain.Objects.Person(personApo.Name);

            //var personIsValid = person.Validate();

            //if (!personIsValid.IsSuccess())
            //{
            //    return new Result<bool>(personIsValid.GetException());
            //}

            //return _personDataService.AddPerson(new PersonDto(person?.Name?.Value ?? ""));

        }

        public Result<PersonDto> GetPersonById(int id)
        {
            throw new NotImplementedException();

            //var personData = _personDataService.GetPersonById(id);

            //var person = new Domain.Objects.Person(personData.Name);

            //var personIsValid = person.Validate();

            //if (!personIsValid.IsSuccess())
            //{
            //    return new Result<PersonDto>(personIsValid.GetException());
            //}

            //return new Result<PersonDto>(new PersonApo { Name = person?.Name?.Value ?? "" });
        }
    }
}
