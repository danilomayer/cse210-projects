using System;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(bool isComplete, string shortName, string description, string points) : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

    // Getters and Setters
    public bool GetIsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    // Constructors
    public void RecordEvent()
    { }
    public bool IsComplete()
    {
        return false;
    }
    public string GetStringRepresentation()
    {
        return "";
    }
}