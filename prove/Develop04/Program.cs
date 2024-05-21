using System;

class Program
{
    static void Main(string[] args)
    {
        ReflectionActivity breathActivity = new ReflectionActivity("Breath Activity", "testing");
        breathActivity.DisplayStartingMessage();
        breathActivity.GetRandomPrompt();
        breathActivity.GetRandomQuestion();


    }
}