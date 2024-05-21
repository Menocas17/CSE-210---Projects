using System.Runtime.CompilerServices;

public class BreathActivity : Activity
{
    private List<string> BreathText = new List<string> {"Breath in", "Breath out"};

    public BreathActivity(string activityName, string description) : base(activityName, description)
    {
        
    }

    public void DisplayBreathingInstructions()
    {
        DateTime startingTime = DateTime.Now;
        DateTime futureTime = startingTime.AddSeconds(GetActivityDuration());

        while(true)
        {
            foreach(string i in BreathText)
            {
                Console.Clear();
                Console.WriteLine(i);
                Counter(5);
            }

            if(DateTime.Now >= futureTime)
            {
                break;
            }
        }

    }
}