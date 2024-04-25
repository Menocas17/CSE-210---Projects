using System;
using System.Reflection.Metadata;





class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }


    static string PromptUserName()
    {
        Console.Write("Please enter you name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter you favorite number: ");
        string userNumberInt = Console.ReadLine();
        int userNumber = int.Parse(userNumberInt);

        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squaredNumber = userNumber * userNumber;

        return squaredNumber;
    }

    static void DisplayResults(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }


    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber (userNumber);

        DisplayResults (userName, squaredNumber);
    }
}

