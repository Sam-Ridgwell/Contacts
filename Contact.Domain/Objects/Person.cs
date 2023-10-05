using Contact.Domain.Fields;

namespace Contact.Domain.Objects
{
    public class Person
    {
        NameField _name = new NameField();

        public string Name { get { return _name.Value; } set { _name.Value = value; } }


        public Person(string name)
        {
            _name.Value = name;
        }
    }
}
