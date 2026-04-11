using System;

public class Swimming : Exercise
{
    private float _numberOfLaps;
    public Swimming(string date, float time, float laps) : base(date, time)
    {
        _numberOfLaps = laps;
    }
    public override float GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62f;
    }
    public override float GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
    public override float GetPace()
    {
        return GetLength() / GetDistance();
    }
}