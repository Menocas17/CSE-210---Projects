public class Lectures : Event
{
    private string _speaker;
    private int _maxCapacity;

    public Lectures(string title, string description, string date, string time, Address address, string speaker, int maxCapacity) :base(title, description, date, time, address)
    {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Type of event: Lecture");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_maxCapacity}");
    }

    public override void ShortDescription()
    {
        Console.WriteLine($"Lecture");
        base.ShortDescription();
    }
}