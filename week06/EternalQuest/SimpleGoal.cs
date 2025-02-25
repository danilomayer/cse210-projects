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

    // Methods
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}