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

        IPersonDataService _personDataService;

        public PersonService(IPersonDataService personDataService)
        {
            this._personDataService = personDataService;
        }

        public Result<bool> AddPerson(IPersonApo personApo)
        {
            Person person;
            try
            {
                person = new Person(personApo.Name);
            }
            catch (Exception ex)
            {
                return new Result<bool>(ex);
            }

            return _personDataService.AddPerson(new PersonDto(person?.Name ?? "") );
        }

        public Result<IPersonApo> GetPersonById(int id)
        {
            var personData = _personDataService.GetPersonById(id);
            Person person;
            try
            {
               person = new Person(personData.Name);
            } 
            catch(Exception ex)
            {
                return new Result<IPersonApo>(ex);
            }

            return new Result<IPersonApo>( new PersonApo { Name = person.Name });
        }
    }
}
