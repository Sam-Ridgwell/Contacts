using Contact.Application.InfrastructureRepository.DataObjects;
using Contact.Application.InfrastructureRepository.Interfaces;
using Contacts.Core;

namespace Contact.Infrastructure.Person
{
    public class PersonDataService : IPersonDataService
    {
        public IPersonDto GetPersonById(int id)
        {
            return new PersonDto("John Smith");
        }

        public Result<bool> AddPerson(PersonDto person)
        {
            return new Result<bool>(true);
        }
    }
}
