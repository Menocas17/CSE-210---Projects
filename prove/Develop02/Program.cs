using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal ();

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine ("PLease select one of the following choices:");
            Console.WriteLine ("1. Write");
            Console.WriteLine ("2. Display");
            Console.WriteLine ("3. Load");
            Console.WriteLine ("4. Save");
            Console.WriteLine ("5. Quit");
            string UserEntry = Console.ReadLine ();
            int UserNumber = int.Parse(UserEntry);

            if (UserNumber == 1)
            {
                journal.AddEntry();
            }

            else if (UserNumber == 2)
            {
                journal.DisplayAll();
            }

            else if (UserNumber == 3)
            {
                Console.WriteLine("What is the name of the file?");
                string filePath = Console.ReadLine();

                journal.LoadFromFile(filePath);

                Console.WriteLine("File succesfully loaded\n");
            }

            else if (UserNumber == 4)
            {
                Console.WriteLine("Please write the name of the file");
                string filePath = Console.ReadLine();
                
                journal.SaveToFile(filePath);

                Console.WriteLine("File succesfully saved at Desktop/Journals\n");
            }

            else if (UserNumber == 5)
            {
                Console.WriteLine("Thank you for writing in your Journal!\n");
                Console.WriteLine("Here is a little advice for a better life:\n");

                DailyAdvice advice = new DailyAdvice();
                string dailyAdvice = advice.GetRandomAdvice();
                Console.WriteLine(dailyAdvice);
                Console.WriteLine("\nBye bye!");

                break;
            }
        }
        }

        
}