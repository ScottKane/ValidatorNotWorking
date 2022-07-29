using FluentValidation;
using ValidatorNotWorking.Requests;

namespace ValidatorNotWorking.Validators;

public class AddEditCustomerCommandValidator : AbstractValidator<AddEditCustomerCommand>
{
    public AddEditCustomerCommandValidator()
    {
        RuleFor(request => request.Title)
            .NotNull()
            .WithMessage("Title is required!");
        RuleFor(request => request.FirstName)
            .NotEmpty()
            .WithMessage("First name is required!");
        RuleFor(request => request.LastName)
            .NotEmpty()
            .WithMessage("Last name is required!");
        
        RuleFor(request => request.Number)
            .NotEmpty()
            .WithMessage("Number is required!");
        RuleFor(request => request.Street)
            .NotEmpty()
            .WithMessage("Street is required!");

        RuleFor(request => request.Email)
            .NotEmpty()
            .WithMessage("Email is required!");
    }
}