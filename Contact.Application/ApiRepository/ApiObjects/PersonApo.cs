using Contact.Application.ApiRepository.Interfaces;

namespace Contact.Application.ApiRepository.ApiObjects
{
    public class PersonApo : IPersonApo
    {
        public string Name { get; set; } = string.Empty;
    }
}
