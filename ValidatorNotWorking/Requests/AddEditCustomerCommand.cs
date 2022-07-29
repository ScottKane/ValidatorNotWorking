namespace ValidatorNotWorking.Requests;

public class AddEditCustomerCommand
{
    public int Id { get; set; }
    public int Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Number { get; set; }
    public string Street { get; set; }
    public string Email { get; set; }
}