using FluentValidation;
using Homework12.Models;

namespace Homework12
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Firstname)
                .NotEmpty().WithMessage("Should not be empty")
                .Length(0, 50).WithMessage("Length is not valid");
            RuleFor(x => x.Lastname)
                .NotEmpty().WithMessage("Should not be empty")
                .Length(0, 50).WithMessage("Length is not valid");
            RuleFor(x => x.JobPosition)
                .NotEmpty().WithMessage("Should not be empty")
                .Length(0, 50).WithMessage("Length is not valid");
            RuleFor(x => x.Salary)
                .NotNull().WithMessage("Please enter value")
                .InclusiveBetween(1, 10000).WithMessage("Please enter number between 1-10000");
            RuleFor(x => x.Workexperience)
                .NotNull().WithMessage("Please enter value");
            
        }
    }
    public class AdressValidator : AbstractValidator<Adress>
    {
        public AdressValidator()
        {
            RuleFor(x => x.Country)
                .NotEmpty().WithMessage("Enter country");
            RuleFor(x => x.City)
                .NotEmpty().WithMessage("Enter City");
            RuleFor(x => x.HomeNumber)
                .NotNull().WithMessage("Enter Homenumber");
        }
    }
}
