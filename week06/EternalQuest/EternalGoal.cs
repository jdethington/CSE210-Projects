using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, string points) : base(name, desc, points)
    {
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