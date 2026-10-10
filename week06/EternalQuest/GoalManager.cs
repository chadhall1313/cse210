using System.Runtime;
using System.IO;
using Microsoft.VisualBasic;


public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        string input = "";
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
            }
        } while (input != "6");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine();
        int number = 0;
        foreach (Goal goal in _goals)
        {
            number += 1;
            Console.WriteLine($"{number}. {goal.GetGoalName()}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Thread.Sleep(4000);
    }
    public void CreateGoal()
    {
        Console.WriteLine("Type an option:");
        Console.WriteLine("1) Simple Goal");
        Console.WriteLine("2) Checklist Goal");
        Console.WriteLine("3) Eternal Goal");
        string input = Console.ReadLine();

        Console.WriteLine("What is the name of this goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a description of this goal?");
        string description = Console.ReadLine();
        Console.WriteLine("How many points will this goal be worth?");
        int points = int.Parse(Console.ReadLine());
        switch (input)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                break;
            case "2":
                Console.WriteLine("How many times do you want to accomplish this goal?");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("How many bonus points will the end goal be worth?");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
                break;
            case "3":
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
        }
        Console.WriteLine("Goal Created!");
        Thread.Sleep(1500);
        Console.Clear();
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to record.");
            return;
        }
        else
        {
            ListGoalNames();
            Console.WriteLine("Which Goal did you accomplish?");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < _goals.Count)
            {
                if (_goals[index].IsComplete())
                {
                    Console.WriteLine("This goal is already complete.");
                }
                else
                {
                    int points = _goals[index].RecordEvent();
                    Console.WriteLine($"Congratulations!! You earned {points} points");
                    _score += points;
                }
            }
            else
            {
                Console.WriteLine("Invalid goal.");
            }
        }
    }
    public void SaveGoals()
    {
        Console.WriteLine("What file will you save to?");
        string file = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What file will you load from?");
        string file = Console.ReadLine();
        string[] info = File.ReadAllLines(file);
        _score = int.Parse(info[0]);
        for (int i = 1; i < info.Length; i++)
        {
            string[] goalInfo = info[i].Split(":");
            string[] deeperInfo = goalInfo[1].Split("|");
            switch (goalInfo[0])
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(deeperInfo[0], deeperInfo[1], int.Parse(deeperInfo[2]));
                    _goals.Add(simpleGoal);
                    break;
                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(deeperInfo[0], deeperInfo[1], int.Parse(deeperInfo[2]), int.Parse(deeperInfo[3]), int.Parse(deeperInfo[4]), int.Parse(deeperInfo[5]));
                    _goals.Add(checklistGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(deeperInfo[0], deeperInfo[1], int.Parse(deeperInfo[2]));
                    _goals.Add(eternalGoal);
                    break;
            }
        }
    }
}