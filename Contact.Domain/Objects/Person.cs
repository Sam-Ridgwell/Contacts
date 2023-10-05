using Contact.Domain.Fields;

namespace Contact.Domain.Objects
{
    public class Person
    {
        readonly NameField _name = new();

        public string Name { get => _name.Value; set => _name.Value = value; }

        public Person(string name)
        {
            _name.Value = name;
        }
    }
}
