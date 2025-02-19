using System;

class GoalManager
{
    private List<Goal> _goal = new List<Goal>();
    private int _score;

    public GoalManager(List<Goal> goal, int score)
    {
        _goal = goal;
        _score = score;
    }

    // Getter for the goal list
    public List<Goal> GetGoals()
    {
        return _goal;
    }
    public void SetGoals(List<Goal> goal)
    {
        _goal = goal;
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
    { }
    public void DisplayPLayerInfo()
    { }
    public void ListGoalNames()
    { }
    public void ListGoalDetails()
    { }
    public void CreateGoal()
    { }
    public void RecordEvent()
    { }
    public void SaveGoals()
    { }
    public void LoadGoals()
    { }
}