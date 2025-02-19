using System;

class NegativeGoal : Goal
{
    public NegativeGoal(string shortName, string description, string points)
        : base(shortName, description, points)
    { }

    // Methods
    public override void RecordEvent()
    {
        // No specific action needed for negative goals
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}
