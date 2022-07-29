namespace ValidatorNotWorking.Requests;

public class RegisterRequest
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? ConfirmPassword { get; set; }
    public bool ActivateUser { get; set; } = true;
    public bool AutoConfirmEmail { get; set; } = true;
    public string Role { get; set; }
}