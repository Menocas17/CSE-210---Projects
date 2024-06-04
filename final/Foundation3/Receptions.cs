public class Receptions : Event
{
    private string _recieptName;
    private string _email;
    private string _message;

    public Receptions(string title, string description, string date, string time, Address address, string recieptName, string email, string message) :base(title, description, date, time, address)
    {
        _recieptName = recieptName;
        _email = email;
        _message = message;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Type of event: Reception");
        Console.WriteLine($"Email sent to guest:\n");
        Console.WriteLine($"- Reciept Name: {_recieptName}  -  Email address: {_email}");
        Console.WriteLine($"- {_message}\n");
    }

    public override void ShortDescription()
    {
        Console.WriteLine($"Reception");
        base.ShortDescription();
    }
}