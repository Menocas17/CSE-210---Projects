using System;

class Program
{
    static void Main(string[] args)


    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        bool keepPLaying = true;
        int attempts = 0;

        while (keepPLaying == true)
        {
            Console.WriteLine("What is your guess?");
            string stringGuess = Console.ReadLine ();
            int numberGuess = int.Parse(stringGuess);

            if (numberGuess == number)
            {
                Console.WriteLine($"You guessed it in {attempts} attempts!");
                Console.WriteLine("Do you want to keep playing?");
                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain == "YES")
                {
                    number = randomGenerator.Next(1, 101);
                    attempts = 0;
                }

                else 
                {
                    keepPLaying = false;
                }
                
            }

            else if (numberGuess < number)
            {
                Console.WriteLine("Higher");
                attempts += 1;
            }

            else if (numberGuess > number)
            {
                Console.WriteLine ("Lower");
                attempts += 1;
             }  
        }

    }
}