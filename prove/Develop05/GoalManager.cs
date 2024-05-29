using System.Diagnostics;
using System.Net;

public class GoalManager
{
    private List <Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void SetScore(int score)
    {
        _score = score;
    }



    public void Start()
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Welcome!");
            Console.WriteLine($"You have {_score} points");

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit\n");
            int userMenuChoice = int.Parse(Console.ReadLine());

            if (userMenuChoice == 1)
            {
                CreateGoal();
                continue;
            }

            else if (userMenuChoice == 2)
            {
                Console.Clear();
                Console.WriteLine("The goals are:\n");
                ListGoals();
                Console.ReadKey();

            }

            else if(userMenuChoice == 5)
            {
                Console.Clear();
                RecordEvent();
            }
        }



    }


    public void CreateGoal()
    {
       Console.Clear();
       Console.WriteLine("Which type of goal you want to create?");
       Console.WriteLine(" 1. Simple Goal");
       Console.WriteLine(" 2. Eternal Goal");
       Console.WriteLine (" 3.CheckList Goal\n");
       int userGoalChoice = int.Parse(Console.ReadLine());

       if (userGoalChoice == 1)
       {
            Console.Clear();
            Console.WriteLine("What is the name of you goal?");
            string name = Console.ReadLine();
            Console.WriteLine("Write the description of your goal:");
            string description = Console.ReadLine();
            Console.WriteLine("How many points are going to be associeted witht his goal?");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal simpleGoal = new SimpleGoal(name, points, description);
            _goals.Add(simpleGoal);
       }

       else if(userGoalChoice == 2)
       {
            Console.Clear();
            Console.WriteLine("What is the name of you goal?");
            string name = Console.ReadLine();
            Console.WriteLine("Write the description of your goal:");
            string description = Console.ReadLine();
            Console.WriteLine("How many points are going to be associeted witht his goal?");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eternalGoal = new EternalGoal(name, points, description);
            _goals.Add(eternalGoal);
       }

       else if(userGoalChoice == 3)
       {
            Console.Clear();
            Console.WriteLine("What is the name of you goal?");
            string name = Console.ReadLine();
            Console.WriteLine("Write the description of your goal:");
            string description = Console.ReadLine();
            Console.WriteLine("How many points are going to be associeted witht his goal?");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times this goal needs to be acomplished for bonus?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for acomplishing in that many times?");
            int bonus = int.Parse(Console.ReadLine());
            CheckListGoal checkListlGoal = new CheckListGoal(name, points, description, target, bonus);
            _goals.Add(checkListlGoal);
       }


    }


    public void ListGoals()
    {
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal.GetGoalDetails());
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal you want to record?");
        int index = 1;

        foreach(Goal goal in _goals)
        {
            
            Console.WriteLine($"{index}. {goal.GetName()}");
            index ++;
        }

        Console.WriteLine();
        int userChoice = int.Parse(Console.ReadLine()) - 1;

        int points = _goals[userChoice].GetPoints();

        if(_goals[userChoice] is SimpleGoal simpleGoal)
        {
            simpleGoal.IsComplete();
        }

        if(_goals[userChoice] is CheckListGoal checkListGoal)
        {
            checkListGoal.SetAmountCompleted();

            if(checkListGoal.GetAmountCompleted() >= checkListGoal.GetTarget())
            {
                points += checkListGoal.GetBonusPoints();
                checkListGoal.IsComplete();
            }

        }
        _score += points;

        Console.WriteLine("Your event has been recorded!");

    }



}