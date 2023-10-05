using Contact.Domain.Fields;
using Contacts.Core;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace Contact.Domain.Objects;

public class BaseObject
{
    public Result<bool> Validate()
    {
        var validationResults = new System.Collections.Generic.List<ValidationResult>();
        var context = new ValidationContext(this);
        var isValid = Validator.TryValidateObject(this, context, validationResults, true);

        var isNameValidResult = ValidateProperties();

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


    
    private (bool, List<ValidationResult>) ValidateProperties()
    {
        // Get all properties on this object  
        PropertyInfo[] properties = GetType().GetProperties();

        var isValid = true;
        var validationResults = new List<ValidationResult>();

        foreach (var property in properties)
        {

            var p = property.PropertyType.GetInterfaces();

            var y = p.Where(p => p.Name.StartsWith("IField")).First();
            // Check if the property type implements the IField<> generic interface  
            if (y != null)
            {
                // Get the instance of the property  
                var fieldValue = property.GetValue(this);
                // Get the Validate method from the IField<> instance  
                var validateMethod = property.PropertyType.GetMethod("Validate");
                if (validateMethod != null && fieldValue != null)
                {
                    // Call the Validate method and get the Result object  
                    if (validateMethod.Invoke(fieldValue, null) is Result<(bool, List<ValidationResult>)> result && !result.GetValue().Item1)
                    {
                        isValid = false;
                        validationResults.AddRange(result.GetValue().Item2);
                    }
                }
            }
        }

        return (isValid, validationResults);
    }
    
}