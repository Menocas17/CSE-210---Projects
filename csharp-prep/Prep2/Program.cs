using System;

class Program
{
    static void Main(string[] args)

    {   

        string gradeLetter;

        Console.WriteLine("What is your grade percentage?");
        string gradeInput = Console.ReadLine();

        int gradePercentage = int.Parse(gradeInput);

        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
            Console.WriteLine($"Congratulations!, you have passed the course with an {gradeLetter}");
        }

        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
            Console.WriteLine($"Congratulations!, you have passed the course with an {gradeLetter}");
        }

        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
            Console.WriteLine($"Congratulations!, you have passed the course with an {gradeLetter}");
        }

        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
            Console.WriteLine($"You have not meet the required grade for passing the course, your grade was {gradeLetter}, please keep trying!");
        }

        else if (gradePercentage < 60)
        {
            gradeLetter = "F";
            Console.WriteLine($"You have not meet the required grade for passing the course, your grade was {gradeLetter}, please keep trying!");
        }


        
    }
}