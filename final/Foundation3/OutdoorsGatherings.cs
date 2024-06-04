public class OutdoorsGatherings : Event
{
    private string _weatherForecast;

    public OutdoorsGatherings(string title, string description, string date, string time, Address address, string wheater) :base(title, description, date, time, address)
    {
        _weatherForecast = wheater;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Type of event: Outdoor Gathering");
        Console.WriteLine($"Statement of weather: {_weatherForecast}\n");
    }

    public override void ShortDescription()
    {
        Console.WriteLine($"Outdoor Gathering");
        base.ShortDescription();
    }
}