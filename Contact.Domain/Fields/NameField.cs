using System.ComponentModel.DataAnnotations;
using Contacts.Core;

namespace Contact.Domain.Fields
{
    /// <summary>
    /// This is a field for the name of a person.
    /// Used to replace the primitive string type.
    /// </summary>
    public class NameField
    {
        private string _value = string.Empty;

        [RegularExpression(@"^[\p{L} -]*$", ErrorMessage = "Name can only contain letters, spaces, and hyphens.")]
        public string Value { get => GetValue(); set => SetValue(value); }

        private void SetValue(string value)
        {
            _value = value;
        }

        private string GetValue()
        {
            return _value;
        }
        public Result<(bool, List<ValidationResult>)> Validate()
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(this);
            var isValid = Validator.TryValidateObject(this, validationContext, validationResults, true);

            return new Result<(bool, List<ValidationResult>)>((isValid, validationResults));
        }
    }
}
