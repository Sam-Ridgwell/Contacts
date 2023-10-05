using Contact.Application.InfrastructureRepository.Interfaces;

namespace Contact.Application.InfrastructureRepository.DataObjects
{
    public class PersonDto : IPersonDto
    {
        private readonly string _name;

        public string Name { get => _name; }

        public PersonDto(string name)
        {
            _name = name;
        }

    }
}
