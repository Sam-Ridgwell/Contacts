using Contact.Application.InfrastructureRepository.DataObjects;

namespace Contact.Application.InfrastructureRepository.Interfaces
{
    public interface IPersonDataService
    {
        public IPersonDto GetPersonById(int id);

        public bool AddPerson(PersonDto person);

    }
}
