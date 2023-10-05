using FluentValidation;

namespace Contact.Domain.Person.Validators
{
    public class PersonValidator : AbstractValidator<Entities.Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required")
                .Matches("^[a-zA-Z -]+$").WithMessage("Name can only contain letters, spaces, and hyphens");
        }
    }
}
