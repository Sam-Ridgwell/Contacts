using Contact.Domain.Person.DataObjects;
using Contact.Domain.Person.Services;

namespace Contact.Infrastructure.Person
{
    public class PersonDataService : IPersonDataService
    {
        public PersonDto GetPersonById(int id)
        {
            return new PersonDto("John Smith");
        }

        public Result<bool> AddPerson(PersonDto person)
        {
            return new Result<bool>(true);
        }
    }
}