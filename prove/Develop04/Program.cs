using System;

class Program
{
    static void Main(string[] args)
    {
        ListingActivity Activity1 = new ListingActivity("Breath Activity", "testing");
        Activity1.Run();


        BreathActivity activity2 = new BreathActivity("Breath Activity", "testing");
        // activity2.Run();
        


    }
}