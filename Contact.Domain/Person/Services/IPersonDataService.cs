using Contact.Domain.Person.DataObjects;
using Contacts.Core;

namespace Contact.Domain.Person.Services
{
    public interface IPersonDataService
    {
        public PersonDto GetPersonById(int id);

        public Result<bool> AddPerson(PersonDto person);
    }
}
