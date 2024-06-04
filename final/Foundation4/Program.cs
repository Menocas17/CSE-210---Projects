using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Swimming swimming = new Swimming(60, "30 May 2024", 5);
        activities.Add(swimming);

        Cycling cycling = new Cycling(45, "01 June 2024", (float)18.75);
        activities.Add(cycling);

        Running running = new Running(30, "03 June 2024", (float)4.8);
        activities.Add(running);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetActivitySummary());
        }
    }
}