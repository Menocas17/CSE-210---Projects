using System.Diagnostics.Contracts;

public class Cycling: Activity
{
    private float _speed;

    public Cycling (int duration, string date, float speed) : base (duration, date)
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
        return $"{GetDate()} {activityType} ({GetDuration()} minutes): Distance {GetDistance():F2} Km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }
}