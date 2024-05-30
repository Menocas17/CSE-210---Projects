using System.Diagnostics;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;

public class GoalManager
{
    private List <Goal> _goals = new List<Goal>();
    private int _score = 0;

    private int _level = 1;
    private int _xp = 0;

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
            Console.WriteLine($"You have {_score} points and are at level {_level} with {_xp} XP");
            Console.WriteLine($"XP needed for next level: {CalculateXpForNextLevel() - _xp}");

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit\n");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userMenuChoice))
            {
                switch (userMenuChoice)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("The goals are:\n");
                        ListGoals();
                        Console.WriteLine("Press any key to return to the main menu.");
                        Console.ReadKey();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        Console.Clear();
                        RecordEvent();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a number between 1 and 6.");
                        Thread.Sleep(2000); 
                        break;
                }
            }
            
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Thread.Sleep(2000); 
            }
        }
    }


    public void CreateGoal()
    {
       Console.Clear();
       Console.WriteLine("Which type of goal you want to create?");
       Console.WriteLine(" 1. Simple Goal");
       Console.WriteLine(" 2. Eternal Goal");
       Console.WriteLine ("3. CheckList Goal\n");
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
        List<Goal> availableGoals = new List<Goal>();
        foreach(Goal goal in _goals)
        {
            if(goal.GetCompleteDetails() == false)
            {
                availableGoals.Add(goal);
            }
        }

        if(availableGoals.Count() == 0)
        {
            Console.WriteLine("You have completed all your goals, create new goals to record events.");
        }

        else
        {
            Console.WriteLine("Which goal you want to record?");
            int index = 1;
            

            foreach(Goal goal in availableGoals)
            {
            
                
                Console.WriteLine($"{index}. {goal.GetName()}");
                index ++;
                
            }

            Console.WriteLine();
            int userChoice = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine();

            int points = availableGoals[userChoice].GetPoints();

            if(availableGoals[userChoice] is SimpleGoal simpleGoal)
            {
                simpleGoal.IsComplete();
                Console.WriteLine("Congratulation, this goal has been completed!!");
                _xp += 100;
            }

            if(availableGoals[userChoice] is CheckListGoal checkListGoal)
            {
                checkListGoal.AddAmountCompleted();

                if(checkListGoal.GetAmountCompleted() >= checkListGoal.GetTarget())
                {
                    points += checkListGoal.GetBonusPoints();
                    checkListGoal.IsComplete();
                    Console.WriteLine("Congratulation, this goal has been completed!!");
                    _xp += 200;
                }

            }

            if(availableGoals[userChoice] is EternalGoal eternalGoal)
            {
                _xp += 50;
            }

            _score += points;

            if (_xp >= CalculateXpForNextLevel())
            {
             LevelUp();
            }

            Console.WriteLine($"Your event has been recorded, you have earned {points}!");
        }

        Thread.Sleep(1800);
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.Write("Enter the name of the file: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

            outputFile.WriteLine($"\n{_xp}");
            outputFile.WriteLine($"{_score}");
            outputFile.WriteLine($"{_level}");


        }

        Console.WriteLine($"You goals have been saved with the following name: {filename}");
        Thread.Sleep(2000);

    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine();
        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                break;
            }

            string [] typeAndDetails = line.Split(":");
            string [] details = typeAndDetails[1].Split("/");

            string name = details[0];
            string description =details[1];
            int points = int.Parse(details[2]);
            string isComplete = details[3];

            string goalType = typeAndDetails[0];

            switch (goalType.Trim())
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(name, points, description);
                    if(isComplete == "True")
                    {
                        simpleGoal.IsComplete();
                    }
                    _goals.Add(simpleGoal);
                    break;

                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(name, points, description);
                    if(isComplete == "True")
                    {
                        eternalGoal.IsComplete();
                    }
                    _goals.Add(eternalGoal);
                    break;
            }       

            if(details.Count() > 4)
            {
                int target = int.Parse(details[4]);
                int amountCompleted = int.Parse(details[5]);
                int bonus = int.Parse(details[6]);

                CheckListGoal checklistGoal = new CheckListGoal(name, points, description, target, bonus);
                checklistGoal.SetAmountCompleted(amountCompleted);
                if(isComplete == "True")
                    {
                        checklistGoal.IsComplete();
                    }
                _goals.Add(checklistGoal);

            }

            _score = int.Parse(lines[lines.Length - 2]);
            _xp = int.Parse(lines[lines.Length - 3]);
            _level = int.Parse(lines[lines.Length - 1]);
        }

    }

    private int CalculateXpForNextLevel()
    {
        return 100 * (_level * _level);
    }

    private void LevelUp()
    {
        _level++;
        _xp = 0; 
        Console.WriteLine($"Congratulations! You reached level {_level}!");
    }


}