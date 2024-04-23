using System;

class Program
{
    static void Main(string[] args)

    {   

        string gradeLetter;
        string gradeSign;

        Console.WriteLine("What is your grade percentage?");
        string gradeInput = Console.ReadLine();

        int gradePercentage = int.Parse(gradeInput);

        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
            int specificGrade = gradePercentage % 10;
      
            if (specificGrade < 3)
            {
                gradeSign = "-";
                Console.WriteLine($"Congratulations!, you have passed the course with an {gradeLetter}{gradeSign}");
            }

            else
            {
                Console.WriteLine($"Congratulations!, you have passed the course with an {gradeLetter}");
            }
        }

        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
            int specificGrade = gradePercentage % 10;
            if (specificGrade >= 7)
            {
                gradeSign = "+";
                Console.WriteLine($"Congratulations!, you have passed the course with an {gradeLetter}{gradeSign}");
            }
            else if (specificGrade < 3)
            {
                gradeSign = "-";
                Console.WriteLine($"Congratulations!, you have passed the course with an {gradeLetter}{gradeSign}");
            }

            else
            {
                Console.WriteLine($"Congratulations!, you have passed the course with an {gradeLetter}");
            }
        }

        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
            int specificGrade = gradePercentage % 10;
            if (specificGrade >= 7)
            {
                gradeSign = "+";
                Console.WriteLine($"Congratulations!, you have passed the course with an {gradeLetter}{gradeSign}");
            }
            else if (specificGrade < 3)
            {
                gradeSign = "-";
                Console.WriteLine($"Congratulations!, you have passed the course with an {gradeLetter}{gradeSign}");
            }

            else
            {
                Console.WriteLine($"Congratulations!, you have passed the course with an {gradeLetter}");
            }
        }

        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
            int specificGrade = gradePercentage % 10;
            if (specificGrade >= 7)
            {
                gradeSign = "+";
                Console.WriteLine($"You have not meet the required grade for passing the course, your grade was {gradeLetter}{gradeSign}, please keep trying!");
            }
            else if (specificGrade < 3)
            {
                gradeSign = "-";
                Console.WriteLine($"You have not meet the required grade for passing the course, your grade was {gradeLetter}{gradeSign}, please keep trying!");
            }

            else
            {
                Console.WriteLine($"You have not meet the required grade for passing the course, your grade was {gradeLetter}, please keep trying!");
            }

           
        }

        else if (gradePercentage < 60)
        {
            gradeLetter = "F";
            Console.WriteLine($"You have not meet the required grade for passing the course, your grade was {gradeLetter}, please keep trying!");
        }


        
    }
}