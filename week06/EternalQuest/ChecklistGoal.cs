using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int bonus, int target) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string name, string description, string points, int bonus, int target, int completed) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = completed;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            return int.Parse(_points) + _bonus;
        }
        return int.Parse(_points);
    }
    public override bool IsComplete()
    {
        if (_amountCompleted < _target)
        {
            return false;
        }
        return true;
    }
    public override string GetDetailsString()
    {
        string details;
        if (IsComplete())
        { details = "[X]"; }
        else
        { details = "[ ]"; }

        details = $"{details} {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";

        return details;

    }
    public override string GetStringRepresentation()
    {
        string saveLine = $"ChecklistGoal,{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
        return saveLine;

    }

}