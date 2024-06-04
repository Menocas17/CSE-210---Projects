using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address address1 = new Address("123 test", "Testaland", "Testing", "Testeo", 12345);
        Address address2 = new Address("123 test", "Testaland", "Testing", "Testeo", 12345);
        Address address3 = new Address("123 test", "Testaland", "Testing", "Testeo", 12345);

        Lectures lecture = new Lectures("Testing1", "A little test to see wheter is working or not", "03 June 2024", "3:35 PM", address1, "Sr. Testando", 15);
        events.Add(lecture);;

        Receptions reception = new Receptions("Testing2", "A little test to see wheter is working or not", "03 June 2024", "3:35 PM", address2, "FulanitoTest", "testing@gmail.com", "This is a test inviation to participate of the testing process of this program, please confirm you assitance.");
        events.Add(reception);

        OutdoorsGatherings outdoorsGathering = new OutdoorsGatherings("Testing3", "A little test to see wheter is working or not", "03 June 2024", "3:35 PM", address3, "On 03 June 2024, it's going to be a mostly cloudy day with a max temp of 87°F and a min of 68°F, with a 60% of humidity");
        events.Add(outdoorsGathering);

        foreach(Event i in events)
        {
            i.DisplayStandardDetails();
            Console.WriteLine();
            i.DisplayFullDetails();
            i.ShortDescription();
            Console.WriteLine("----------------------------------");

        }

    }
}