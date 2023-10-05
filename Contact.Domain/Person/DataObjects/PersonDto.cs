namespace Contact.Domain.Person.DataObjects
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