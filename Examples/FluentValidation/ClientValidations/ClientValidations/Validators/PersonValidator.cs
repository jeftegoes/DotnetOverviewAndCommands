using FluentValidation;

namespace ClientValidations.Validators
{
    public class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty().WithMessage("{PropertyName} is empty.")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} is invalid.")
                .Must(BeAValidName).WithMessage("{PropertyName} constains invalid characters.");

            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is empty.")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} is invalid.")
                .Must(BeAValidName).WithMessage("{PropertyName} constains invalid characters.");
            RuleFor(p => p.DateOfBirth)
                .Must(BeAValidAge).WithMessage("Invalid {PropertyName}");
        }

        private bool BeAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = date.Year;

            if (dobYear <= currentYear && dobYear > (currentYear - 100))
                return true;

            return false;
        }

        private bool BeAValidName(string name)
        {
            name = name.Replace(" ", string.Empty);
            name = name.Replace("-", string.Empty);

            return name.All(Char.IsLetter);
        }
    }
}