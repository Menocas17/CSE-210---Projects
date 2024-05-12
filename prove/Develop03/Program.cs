using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library ();

        Console.WriteLine("Welcome to the Book of Mormon Scriptures Learning Tool");
        Console.WriteLine("Please choose of the following options (type the number):");
        Console.WriteLine("1. Memorize a random scripture\n2. Memorize an scripture of your choice");
        string chosenOption = Console.ReadLine();
        int chosenNumber = int.Parse(chosenOption);


        if(chosenNumber == 1)
        {
            Console.Clear();
            library.GetRandomScripture();
            Console.WriteLine($"{library.GetScriptureReference()}\n{library.GetScriptureText()}");
        }

        else if (chosenNumber == 2)
        {
            
            Console.WriteLine("Enter the scripture (example: 1 Nephi 3:7):");
            string specificScripture = Console.ReadLine();
            Console.Clear();
            library.GetSpecificScripture(specificScripture);
            Console.WriteLine($"{library.GetScriptureReference()}\n{library.GetScriptureText()}");
        }

        Scripture currentScripture = library.GetCurrentScripture();
        currentScripture.AddWords();


        while(true)
        {
            Console.WriteLine ("\nPress enter to hide a random word, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if(input == "")
            {
                currentScripture.HideRandomWord();
                Console.Clear();
                Console.WriteLine($"{library.GetScriptureReference()}\n{currentScripture.DisplayText()}");

                if (currentScripture.IsCompletyHidden())
                {
                    Console.WriteLine("Do you want to 'reset' the scripture or 'quit'?, type either option:");
                    string endInput = Console.ReadLine();

                    if(endInput.ToLower() == "reset")
                    {
                        currentScripture.ResetScripture();
                        continue;
                    }

                    else if (endInput.ToLower() == "quit")
                    {
                        break;
                    }
                }

            }

            else if (input.ToLower() == "quit")
            {
                break;
            }

            
        };


   
    }
}