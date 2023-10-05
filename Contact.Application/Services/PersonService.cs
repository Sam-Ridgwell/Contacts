using Contact.Application.ApiRepository.ApiObjects;
using Contact.Application.ApiRepository.Interfaces;
using Contact.Application.InfrastructureRepository.DataObjects;
using Contact.Application.InfrastructureRepository.Interfaces;
using Contact.Application.Services.Interfaces;
using Contact.Domain.Objects;

namespace Contact.Application.Services
{
    public class PersonService : IPersonService
    {

        IPersonDataService _personDataService;

        public PersonService(IPersonDataService personDataService)
        {
            this._personDataService = personDataService;
        }

        public bool AddPerson(IPersonApo personApo)
        {
            Person person = new Person(personApo.Name);

            return _personDataService.AddPerson(new PersonDto(person.Name) );
        }

        public IPersonApo GetPersonById(int id)
        {
            var personData = _personDataService.GetPersonById(id);

            Person person = new Person(personData.Name);

            return new PersonApo { Name = person.Name };
        }
    }
}
