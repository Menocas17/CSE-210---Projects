using System.Threading.Tasks;

public class ListingActivity : Activity 
{
    private List<string> _prompts = new List<string> 
    {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
    };

    private int _count;

    public ListingActivity(string activityName, string description) : base (activityName, description)
    {

    }

    public int GetCount()
    {
        return _count;
    }

    public string GetRandomListingPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);

        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }

    public void GetListFromUser()
    {

        Console.WriteLine("List as many responses you can to the following prompt:");
        string randomPrompt = GetRandomListingPrompt();
        Console.WriteLine($"\n --- {randomPrompt} ---");
        Console.WriteLine("You may begin in :");
        Counter(6);
        Console.Clear();
        Console.WriteLine($" --- {randomPrompt} --- ");

        DateTime startingTime = DateTime.Now;
        DateTime futureTime = startingTime.AddSeconds(GetActivityDuration());

        while(true)
        {
            if(DateTime.Now >= futureTime)
            {
                break;
            }

            Console.Write("> ");
            string userEntry = Console.ReadLine();
            _count += 1;
        }

        while (Console.KeyAvailable)
        {
            string userEntry = Console.ReadLine();
            _count += 1;
        }

    
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetListFromUser();
        Console.WriteLine($"\n You listed {_count} items!");
        DisplayEndingMessage();

    }


}