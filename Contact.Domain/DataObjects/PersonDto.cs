namespace Contact.Domain.DataObjects
{
    public class PersonDto
    {
        public string Name { get; }

        public PersonDto(string name)
        {
            Name = name;
        }
    }
}