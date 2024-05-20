using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssingment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssingment.GetSummary());
        Console.WriteLine(mathAssingment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("\nMary Waters", "European History", "The Cause of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}