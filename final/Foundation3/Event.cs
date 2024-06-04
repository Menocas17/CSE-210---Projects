using System.Net.Sockets;
using System.Reflection;

public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event (string title, string description, string date, string time, Address address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    } 

    public void DisplayStandardDetails()
    {
        Console.WriteLine("Title: {_eventTitle}:");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"Date and time: {_date} at {_time}");
        Console.WriteLine($"Address: {_address.GetFullAddress()}");

    }

    public virtual void DisplayFullDetails()
    {
        DisplayFullDetails();

    }

    public virtual void ShortDescription()
    {
        Console.WriteLine($"(type of event) - {_eventTitle}, {_date}");
    }
}