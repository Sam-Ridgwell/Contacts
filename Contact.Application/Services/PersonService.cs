using Contact.Application.ApiRepository.ApiObjects;
using Contact.Application.ApiRepository.Interfaces;
using Contact.Application.InfrastructureRepository.DataObjects;
using Contact.Application.InfrastructureRepository.Interfaces;
using Contact.Application.Services.Interfaces;
using Contact.Domain.Objects;
using Contacts.Core;

namespace Contact.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonDataService _personDataService;

        public PersonService(IPersonDataService personDataService)
        {
            this._personDataService = personDataService;
        }

        public Result<bool> AddPerson(IPersonApo personApo)
        {
            var person = new Person(personApo.Name);

            var personIsValid = person.Validate();

            if (!personIsValid.IsSuccess())
            {
                return new Result<bool>(personIsValid.GetException());
            }

            return _personDataService.AddPerson(new PersonDto(person?.Name ?? ""));

        }

        public Result<IPersonApo> GetPersonById(int id)
        {
            var personData = _personDataService.GetPersonById(id);

            var person = new Person(personData.Name);

            var personIsValid = person.Validate();

            if (!personIsValid.IsSuccess())
            {
                return new Result<IPersonApo>(personIsValid.GetException());
            }

            return new Result<IPersonApo>( new PersonApo { Name = person.Name });
        }
    }
}
