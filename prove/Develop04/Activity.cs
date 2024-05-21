public class Activity
{
    private string _activityName;
    private string _description;
    private int  _activityDuration;
    private string _endingMessage;

    public Activity ()
    {
        _activityName = "Unknown";
        _activityDuration = 0;
        _description = "null";
        _endingMessage = "Time is over, good job, you're doing great!!!";
    }

    public Activity (string activityName, string description, int activityDuration)
    {
        _activityName = activityName;
        _description = description;
        _activityDuration = activityDuration;
        _endingMessage = "Time is over, good job, you're doing great!!!";
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void DisplayStartingMessage()

    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_activityName}\n\n{_description}\n");

        while(true)
        {
            Console.Write("How long, in seconds, would you like for your session (min 10 sec)?  ");
            string activityDurationString = Console.ReadLine();
            _activityDuration = int.Parse(activityDurationString);

            if(_activityDuration < 10)
            {
                Console.WriteLine("Sorry, the duration you entered is not valid");
                continue;
            }

            else
            {
                break;
            }
        }
        

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine(_endingMessage);
        
    }

    public void WaitingAnimation()
    {
        List<string> animationStrings = new List<string> {"|", "/", "-", "\\", "|"};
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        while(true)
        {
            foreach(string i in animationStrings)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");


            }

            if(DateTime.Now >= futureTime)
            {
                break;
            }
        }

    }

    public void Counter (int duration)
    {
        for(int i = duration ; i >= 0; i--)
        {
            Console.Write("\r{0:D" + Math.Floor(Math.Log10(duration) + 1) + "}", i);
            Thread.Sleep(1000);  
            
          
        }
    }
    
}