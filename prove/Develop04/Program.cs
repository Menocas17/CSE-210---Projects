using System;

class Program
{
    static void Main(string[] args)
    {
        BreathActivity breathActivity = new BreathActivity("Breath Activity", "testing", 10);
        breathActivity.DisplayStartingMessage();
        breathActivity.DisplayBreathingInstructions();


    }
}