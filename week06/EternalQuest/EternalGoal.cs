using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, string points) : base(name, desc, points)
    {
    }

    public override int RecordEvent()
    {
        return int.Parse(_points);
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        string saveLine = $"EternalGoal,{_shortName},{_description},{_points}";
        return saveLine;
    }

}