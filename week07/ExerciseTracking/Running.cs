using System;

public class Running : Exercise
{
    private float _distance;
    public Running(string date, float time, float distance) : base(date, time)
    {
        _distance = distance;
    }
    public override float GetDistance() => _distance;
    public override float GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }

    public override float GetPace()
    {
        return GetLength() / GetDistance();
    }
}