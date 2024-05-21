public class Activity
{
    private string _activityName;
    private string _description;
    private int  _activityDuration;
    private string _endingMessage;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        _endingMessage = "Good job, you're doing great!!!";
    }

    public string GetStartingMessage()
    {
        return $"{_activityName}\n{_description}";
    }

    public string GetEndingMessage()
    {
        return _endingMessage;
        
    }

    public void SetActivityDuration (int activityDuration)
    {
        _activityDuration = activityDuration;
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