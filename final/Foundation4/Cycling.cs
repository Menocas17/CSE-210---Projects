using System.Diagnostics.Contracts;

public class Cycling: Activity
{
    private float _speed;

    public Cycling (float duration, string date, float speed) : base (duration, date)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed * GetDuration();

    }

    public override float GetPace()
    {
        return 60 / _speed;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override string GetActivitySummary()
    {
        string activityType = "Cycling";
        return $"{GetDate()} {activityType} ({GetDuration()}): Distance {GetDistance()}, Speed {GetSpeed()}, Pace {GetPace()}";
    }
}