using System.ComponentModel.DataAnnotations;

namespace Contact.Domain.Fields
{
    /// <summary>
    /// This is a field for the name of a person.
    /// Used to replace the primitive string type.
    /// </summary>
    public class NameField
    {
        private string _value = string.Empty;

        public string Value { get => GetValue(); set => SetValue(value); }

        private void SetValue(string value)
        {
            if (!IsValueValid(value))
            {
                throw new ValidationException("Name is not valid");
            }

            _value = value;
        }

        private static bool IsValueValid(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            return true;
        }

        private string GetValue()
        {
            return _value;
        }
    }
}
