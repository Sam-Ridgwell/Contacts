using System.ComponentModel.DataAnnotations;
using Contact.Domain.Fields;

namespace Contact.Domain.Objects
{
    public class Person : BaseObject
    {

        [Required]
        public NameField? Name { get; set; }

        public Person(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Name = null;
            }
            
            if(!string.IsNullOrWhiteSpace(name) && Name == null)
            {
                Name = new NameField
                {
                    Value = name
                };
            }
            
        }
    }
}
