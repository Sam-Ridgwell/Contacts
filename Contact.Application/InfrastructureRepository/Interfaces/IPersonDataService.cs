using Contact.Application.InfrastructureRepository.DataObjects;
using Contacts.Core;

namespace Contact.Application.InfrastructureRepository.Interfaces
{
    public interface IPersonDataService
    {
        public IPersonDto GetPersonById(int id);

        public Result<bool> AddPerson(PersonDto person);

    }
}
