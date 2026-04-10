using System;

public class SimpleGoal : Goal      
{
    private bool _isComplete;

public SimpleGoal(string name, string desc, string points) : base(name, desc, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }

}