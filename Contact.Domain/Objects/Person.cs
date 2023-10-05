using System.ComponentModel.DataAnnotations;
using System.Text;
using Contact.Domain.Fields;
using Contacts.Core;

namespace Contact.Domain.Objects
{
    public class Person
    {
        readonly NameField _name = new();

        [Required]
        public string Name { get => _name.Value; set => _name.Value = value; }

        public Person(string name)
        {
            _name.Value = name;
        }

        public Result<bool> Validate()
        {
            var validationResults = new System.Collections.Generic.List<ValidationResult>();
            var context = new ValidationContext(this);
            var isValid = Validator.TryValidateObject(this, context, validationResults, true);

            var isNameValidResult = _name.Validate().GetValue();

            if (!isNameValidResult.Item1)
            {
                isValid = false;
                validationResults.AddRange(isNameValidResult.Item2);
            }

            if (!isValid)
            {
                var validationErrors = new StringBuilder();

                foreach (var result in validationResults)
                {
                    validationErrors.AppendLine(result.ErrorMessage);
                }
                
                return new Result<bool>(new ValidationException(validationErrors.ToString()));

            }

            return new Result<bool>(isValid);
            
        }
    }
}
