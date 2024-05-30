// Exceeding requirements:

//     Add a verification step in order to verify if a goal was already completed before being able to record an event, and only display the uncompleted or eternal goals. 

//     Add a verification step to the main menu so the user can only enter one of the available options

//     Add a simple leveling system so the user can keep track of his lvl and xp.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}