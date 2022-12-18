using final_API.Models;
using FluentValidation;

namespace final_API.Validations
{
    public class RegistrationValidator : AbstractValidator<RegistrationModel>
    {
        RegistrationValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Age).NotEmpty();
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
            RuleFor(x => x.Salary).NotEmpty().GreaterThan(0);
        }
    }
}
