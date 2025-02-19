using System;

class ProgressGoal : Goal
{
    private int _currentProgress;
    private int _targetProgress;

    public ProgressGoal(int currentProgress, int targetProgress, string shortName, string description, string points)
        : base(shortName, description, points)
    {
        _currentProgress = currentProgress;
        _targetProgress = targetProgress;
    }

    // Getters and Setters
    public int GetCurrentProgress()
    {
        return _currentProgress;
    }
    public void SetCurrentProgress(int currentProgress)
    {
        _currentProgress = currentProgress;
    }

    public int GetTargetProgress()
    {
        return _targetProgress;
    }
    public void SetTargetProgress(int targetProgress)
    {
        _targetProgress = targetProgress;
    }

    // Methods
    public override void RecordEvent()
    {
        _currentProgress++;
    }

    public override bool IsComplete()
    {
        return _currentProgress >= _targetProgress;
    }

    public override string GetStringRepresentation()
    {
        return $"ProgressGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_currentProgress}|{_targetProgress}";
    }
}
