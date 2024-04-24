using System;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int> ();
        bool keepAsking = true;
        int sumNumbers = 0;
        int biggestNumber;
        int smallestPositiveNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (keepAsking == true)
        {   
            Console.Write("Enter a number:");
            string stringNumber = Console.ReadLine();
            int numberInput = int.Parse(stringNumber);
            
            numbers.Add(numberInput);

            if (numberInput == 0)
            {
                keepAsking = false;

                numbers.RemoveAt(numbers.Count - 1);

                foreach (int number in numbers)
                {
                    sumNumbers += number;
                }

                int numbersCount = numbers.Count;
                double avarage = (double)sumNumbers / numbersCount;
                biggestNumber = numbers.Max();
                numbers.Sort();

                foreach (int number in numbers)
                {
                    if (number > 0)
                    {
                        smallestPositiveNumber = number;
                        break;
                    }
                }

                Console.WriteLine($"The sum of the numbers is: {sumNumbers}");
                Console.WriteLine($"The avarage of the numbers is: {avarage}");
                Console.WriteLine($"The largest number is: {biggestNumber}");
                Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
                Console.WriteLine("The sorted list is:");

                foreach(int number in numbers)
                {
                    Console.WriteLine($"{number}");
                }
            }
        }
        
    }
}