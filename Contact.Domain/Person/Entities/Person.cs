namespace Contact.Domain.Person.Entities
{
    public class Person
    { 
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}
