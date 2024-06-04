public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming (float duration, string date, int numberOfLaps) : base (duration, date)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override float GetDistance()
    {
        return _numberOfLaps * 50 / 1000;

    }

    public override float GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetActivitySummary()
    {
        string activityType = "Swimming";
        return $"{GetDate()} {activityType} ({GetDuration()}): Distance {GetDistance()}, Speed {GetSpeed()}, Pace {GetPace()}";
    }
}