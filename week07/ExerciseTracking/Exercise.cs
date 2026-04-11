using System;

public abstract class Exercise
{
    private string _date;
    private float _lengthOfExerciseMinutes;

    public Exercise(string date, float time)
    {
        _date = date;
        _lengthOfExerciseMinutes = time;
    }

    public float GetLength() => _lengthOfExerciseMinutes;
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public virtual string GetSummary()
    {
        // string exerciseName = this.GetType().Name;
        return $"{_date} {this.GetType().Name} ({_lengthOfExerciseMinutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph. Pace: {GetPace():F1} Min per mile";
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }
}