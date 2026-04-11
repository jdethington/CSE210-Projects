using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points)
    : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, string points, bool complete)
    : base(name, description, points)
    {
        _isComplete = complete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return int.Parse(_points);
        
    }
    public override bool IsComplete()
    // This method should return true if the goal is completed.
    // The way you determine if a goal is complete is different for each type of goal.
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    // This method should provide all of the details of a goal
    //  in a way that is easy to save to a file, and then load later.
    {
        string saveLine = $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";
        return saveLine;
    }

}