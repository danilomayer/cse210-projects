using System;
using System.Collections.Generic;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    // Getter for the goal list
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    public void SetGoals(List<Goal> goals)
    {
        _goals = goals;
    }
    public int GetScore()
    {
        return _score;
    }
    public void SetScore(int score)
    {
        _score = score;
    }

    // Methods
    public void Start()
    {
        // Initialize goals and score
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter short name: ");
        string shortName = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        string points = Console.ReadLine();

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(false, shortName, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(shortName, description, points));
                break;
            case "3":
                Console.Write("Enter target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(0, target, bonus, shortName, description, points));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetShortName() == goalName)
            {
                goal.RecordEvent();
                _score += int.Parse(goal.GetPoints());
                break;
            }
        }
    }

    public void SaveGoals()
    {
        // Implement saving goals to a file
    }

    public void LoadGoals()
    {
        // Implement loading goals from a file
    }
}