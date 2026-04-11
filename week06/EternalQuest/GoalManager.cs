using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    protected int _score = 0;
    private string _fileName;

    public GoalManager()
    {

    }
    public void Start()
    // This is the "main" function for this class. 
    // It is called by Program.cs, and then runs the menu loop.
    {
        Boolean playGoals = true;
        if (_fileName != null)
        {
            LoadGoal();
        }else
        {
            Console.WriteLine("What is the name of you new Eternal Quest Goals file?");
            Console.Write("> ");
            _fileName = $"{Console.ReadLine()}.txt";
            SaveGoal();
        }
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goal");
            // Console.WriteLine("  3. Save Goal");
            // Console.WriteLine("  4. Load Goal");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice form the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    SaveGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                // case "3":
                //     SaveGoal();
                //     break;
                // case "4":
                //     LoadGoal();
                //     break;
                case "3":
                    RecordEvent();
                    SaveGoal();
                    break;
                case "4":
                    playGoals = false;
                    break;
                default:

                    break;
            }
        } while (playGoals);
    }
    public void DisplayPlayerInfo()
    // Displays the players current score.
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }
    public void ListGoalNames()
    // Lists the names of each of the goals.
    {
        int i = 0;
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"  {i}. {goal.GetName()}");
        }
    }
    public void ListGoalDetails()
    // Lists the details of each goal 
    // (including the checkbox of whether it is complete).
    {
        Console.WriteLine("The goals are:");
        if (_goals.Count == 0)
        {
            Console.Write("You do not have any goals yet.  Please enter a goal");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
        }
        else
        {
            int i = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"  {i}. {goal.GetDetailsString()}");
                i++;
            }
        }
    }
    public void CreateGoal()
    // Asks the user for the information about a new goal. 
    // Then, creates the goal and adds it to the list.
    {
        Boolean newGoal = true;
        int j = 1;
        int choice;
        string name;
        string description;
        string points;
        do
        {

            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goals");
            Console.WriteLine("  2. Eternal Goals");
            Console.WriteLine("  3. Checklist Goals");
            Console.Write("Which type of goal would you like to create?: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out choice))
            {
                Console.Write("That is not a valid number. Please try again");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                j++;
                continue;
            }
            if (choice < 1 || choice > 3)
            {
                if (j == 3)
                {
                    Console.Write("Something must not be working.  Lets start over");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    break;
                }
                Console.Write("That is not a valid choice.  Please try again");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                j++;
            }
            else
            {
                newGoal = false;
            }
        } while (newGoal);
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine().Trim();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine().Trim();
        Console.Write("What is the amount of points associated with this goal? ");
        points = Console.ReadLine().Trim();

        switch (choice)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine().Trim());
                Console.Write($"What is the bonus for accomplishing it {target} times? ");
                int bonus = int.Parse(Console.ReadLine().Trim());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, target);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.Write("You didn't make a good choice.  You may start over");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                break;
        }
    }
    public void RecordEvent()
    // Asks the user which goal they have done and then 
    // records the event by calling the 
    // RecordEvent method on that goal.
    {
        Boolean choice = true;
        int j = 1;
        if (_goals.Count > 0)
        {

            do
            {
                Console.WriteLine("The goals are:");
                ListGoalNames();
                Console.Write("Which goal did accomplish? ");
                int did = int.Parse(Console.ReadLine());
                if (did < 1 || did > _goals.Count())
                {
                    if (j == 3)
                    {
                        Console.Write("Something must not be working.  Lets start over");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(1000);
                        }
                        break;
                    }
                    Console.Write("That is not a valid choice.  Please try again");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine();
                    j++;
                }
                else
                {
                    _score += _goals[did - 1].RecordEvent();
                    choice = false;
                }
            } while (choice);
        }
        else
        {
            Console.Write("Something must not be working.  You do not have any goals yet!  Lets start over");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
        }
    }
    public void SaveGoal()
    // Saves the list of goals to a file.
    {
        // string filename = "myGoals.txt";

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(_score);// Saves the score to the first line
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    // Loads the list of goals from a file.
    public void LoadGoal()
    {
        _goals = new List<Goal>();
        // string filename = "myGoals.txt";
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            // part[0] = _score/Goal
            // part[1] = name
            // part[2] = description
            // part[3] = points
            // part[4] = complete/bonus
            // part[5] = target
            // part[6] = amountComplete
            switch (parts[0])
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4]));
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                    _goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], parts[3], Int32.Parse(parts[4]), Int32.Parse(parts[5]), Int32.Parse(parts[6]));
                    _goals.Add(checklistGoal);
                    break;
                default:
                    _score = int.Parse(parts[0]);
                    break;
            }
        }
    }
    public void FileToUse(string file)
    {
        _fileName = file;
    }
}