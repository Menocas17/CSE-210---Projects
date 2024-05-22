using System;
using System.Configuration.Assemblies;

class Program
{
    static void Main(string[] args)
    {
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        BreathActivity breathActivity = new BreathActivity("Breath Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            
        Dictionary<string, ActivityStats> summary = new Dictionary<string, ActivityStats>();

        while(true)
        {
            
            

            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Strat breathin activity");
            Console.WriteLine("  2. Strat reflecting activity");
            Console.WriteLine("  3. Strat listing activity");
            Console.WriteLine("  4. View you session's summary");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu:");
            string userInputString = Console.ReadLine();
            int userInput = int.Parse(userInputString);

            if(userInput == 5)
            {
                break;
            }

            else if(userInput == 1)
            {
                breathActivity.Run();
                UpdateActivityStats(summary, breathActivity.GetActivityName(), breathActivity.GetActivityDuration());
                continue;
            }

            else if (userInput == 2)
            {
                reflectionActivity.Run();
                UpdateActivityStats(summary, reflectionActivity.GetActivityName(), reflectionActivity.GetActivityDuration());
                continue;
            }

            else if (userInput == 3)
            {
                listingActivity.Run();
                UpdateActivityStats(summary, listingActivity.GetActivityName(), listingActivity.GetActivityDuration());
                continue;
            }

            else if (userInput == 4)
            {
                Console.Clear();
                if(summary.Count == 0)
                {
                    Console.WriteLine("You have not gone through any activity during this session yet.");
                    Thread.Sleep(3000);
                    continue;
                }

                else
                {
                    int timeSpent = 0;
                    foreach(var activity in summary)
                    {
                        
                        Console.WriteLine($"{activity.Key} = {activity.Value.GetUsageCount()} times, and {activity.Value.GetTimeSpent()} seconds");
                        timeSpent += activity.Value.GetTimeSpent();
                       
                    }
                    
                     Console.WriteLine($"\nYou have spent {timeSpent} seconds within the mindfull activities");
                    Console.Write("Press enter to return to the main menu.");
                    Console.ReadLine();

                    continue;
                }
                
            }

            else
            {
                Console.WriteLine("Please choose a valid option.");
                continue;
            }
        }

    }

    static void UpdateActivityStats(Dictionary<string, ActivityStats> summary, string activityName, int activityDuration)
    {
        if(summary.ContainsKey(activityName))
        {
            summary[activityName].UpdateTimeSpent(activityDuration);
            summary[activityName].UpdateUsageCount();
        }

        else
        {
            summary.Add(activityName, new ActivityStats(activityDuration));
        }
    }
}