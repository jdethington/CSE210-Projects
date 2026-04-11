using System;

public class Cycling : Exercise
{
    private float _speed;
    public Cycling(string date, float time, float speed) : base(date, time)
    {
        _speed = speed;
    }
    public override float GetDistance()
    {
        return GetSpeed() * GetLength() / 60;
    }
    public override float GetSpeed() => _speed;
    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
}