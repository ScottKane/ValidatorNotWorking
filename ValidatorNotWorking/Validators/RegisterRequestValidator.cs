using FluentValidation;
using ValidatorNotWorking.Requests;

namespace ValidatorNotWorking.Validators;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator()
    {
        RuleFor(request => request.FirstName)
            .NotEmpty()
            .WithMessage(x => "First Name is required");
        RuleFor(request => request.LastName)
            .NotEmpty()
            .WithMessage(x => "Last Name is required");
        RuleFor(request => request.Email)
            .NotEmpty()
            .WithMessage(x => "Email is required")
            .EmailAddress()
            .WithMessage(x => "Email is not correct");
        RuleFor(request => request.Password)
            .NotEmpty()
            .WithMessage(x => "Password is required!")
            .MinimumLength(8)
            .WithMessage("Password must be at least of length 8")
            .Matches(@"[A-Z]")
            .WithMessage("Password must contain at least one capital letter")
            .Matches(@"[a-z]")
            .WithMessage("Password must contain at least one lowercase letter")
            .Matches(@"[0-9]")
            .WithMessage("Password must contain at least one digit");
        RuleFor(request => request.ConfirmPassword)
            .Must(x => !string.IsNullOrWhiteSpace(x))
            .WithMessage(x => "Password Confirmation is required!")
            .Equal(request => request.Password)
            .WithMessage(x => "Passwords don't match");
        RuleFor(request => request.Role)
            .NotEmpty()
            .WithMessage("A role must be selected");
    }
}