using Contact.Domain.DataObjects;
using Contacts.Core;

namespace Contact.Application.Person
{
    public interface IPersonService
    {
        public Result<PersonDto> GetPersonById(int id);

        public Result<bool> AddPerson(PersonDto person);
    }
}
