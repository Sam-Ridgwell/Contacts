using Contact.Application.InfrastructureRepository.Interfaces;

namespace Contact.Application.InfrastructureRepository.DataObjects
{
    public class PersonDto : IPersonDto
    {
        public string Name { get; }

        public PersonDto(string name)
        {
            Name = name;
        }
    }
}