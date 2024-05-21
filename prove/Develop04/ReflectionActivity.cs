public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> 
   {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _reflectQuestions = new List<string>
   {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string activityName, string description) : base(activityName, description)
    {

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);

        string randomPrompt = _prompts[randomIndex];

        Console.WriteLine(randomPrompt) ;
    }

    public void GetRandomQuestion ()
    {
        DateTime startingTime = DateTime.Now;
        DateTime futureTime = startingTime.AddSeconds(GetActivityDuration());

        Random random = new Random();

      List<string> printedQuestions = new List<string>();

        while(true)
        {

             if(DateTime.Now >= futureTime)
            {
                DisplayEndingMessage();
                break;
            }

            List<string> availableQuestions = _reflectQuestions.Except(printedQuestions).ToList();

            if (availableQuestions.Count == 0)
            {
         
            printedQuestions.Clear();
            availableQuestions = _reflectQuestions.ToList();
            }

            int randomIndex = random.Next(0, availableQuestions.Count);
            string randomQuestion = availableQuestions[randomIndex];

            Console.WriteLine(randomQuestion);

            printedQuestions.Add(randomQuestion);

           WaitingAnimation(15);
        }
            

           
    }
}
