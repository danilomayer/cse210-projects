using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level;
    private int _xp;

    public GoalManager()
    {
        _score = 0;
        _level = 1;
        _xp = 0;
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
    public int GetLevel()
    {
        return _level;
    }
    public int GetXP()
    {
        return _xp;
    }

    // Methods
    public void Start()
    {
        // Initialize goals and score
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _xp = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine($"Level: {_level}");
        Console.WriteLine($"XP: {_xp}");
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
        Console.WriteLine("4. Progress Goal");
        Console.WriteLine("5. Negative Goal");
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
            case "4":
                Console.Write("Enter target progress: ");
                int targetProgress = int.Parse(Console.ReadLine());
                _goals.Add(new ProgressGoal(0, targetProgress, shortName, description, points));
                break;
            case "5":
                _goals.Add(new NegativeGoal(shortName, description, points));
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
                int points = int.Parse(goal.GetPoints());
                _score += points;
                _xp += points;
                CheckLevelUp();
                break;
            }
        }
    }

    private void CheckLevelUp()
    {
        int xpForNextLevel = _level * 100;
        if (_xp >= xpForNextLevel)
        {
            _level++;
            _xp -= xpForNextLevel;
            Console.WriteLine($"Congratulations! You've leveled up to Level {_level}!");
        }
    }

    public void SaveGoals()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(_score);
                writer.WriteLine(_level);
                writer.WriteLine(_xp);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        try
        {
            if (File.Exists("goals.txt"))
            {
                using (StreamReader reader = new StreamReader("goals.txt"))
                {
                    _score = int.Parse(reader.ReadLine());
                    _level = int.Parse(reader.ReadLine());
                    _xp = int.Parse(reader.ReadLine());
                    _goals = new List<Goal>();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        string type = parts[0];
                        string shortName = parts[1];
                        string description = parts[2];
                        string points = parts[3];

                        switch (type)
                        {
                            case "SimpleGoal":
                                bool isComplete = bool.Parse(parts[4]);
                                _goals.Add(new SimpleGoal(isComplete, shortName, description, points));
                                break;
                            case "EternalGoal":
                                _goals.Add(new EternalGoal(shortName, description, points));
                                break;
                            case "ChecklistGoal":
                                int amountCompleted = int.Parse(parts[4]);
                                int target = int.Parse(parts[5]);
                                int bonus = int.Parse(parts[6]);
                                _goals.Add(new ChecklistGoal(amountCompleted, target, bonus, shortName, description, points));
                                break;
                            case "ProgressGoal":
                                int currentProgress = int.Parse(parts[4]);
                                int targetProgress = int.Parse(parts[5]);
                                _goals.Add(new ProgressGoal(currentProgress, targetProgress, shortName, description, points));
                                break;
                            case "NegativeGoal":
                                _goals.Add(new NegativeGoal(shortName, description, points));
                                break;
                        }
                    }
                }
                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
        }
    }
}