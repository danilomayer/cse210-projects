using System;

class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Getters and Setters
    public string GetShortName()
    {
        return _shortName;
    }
    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetPoints()
    {
        return _points;
    }
    public void SetPoints(string points)
    {
        _points = points;
    }

    // Methods
    public virtual void RecordEvent()
    { }

    public virtual bool IsComplete()
    {
        return false;
    }

    public string GetDetailString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}