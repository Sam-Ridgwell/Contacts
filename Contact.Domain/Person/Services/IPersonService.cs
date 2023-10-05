using Contact.Domain.Person.DataObjects;
using Contacts.Core;

namespace Contact.Domain.Person.Services
{
    public interface IPersonService
    {
        public Result<PersonDto> GetPersonById(int id);

        public Result<bool> AddPerson(PersonDto person);
    }
}
