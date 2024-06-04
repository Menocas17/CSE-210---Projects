public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming (int duration, string date, int numberOfLaps) : base (duration, date)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override float GetDistance()
    {
        return _numberOfLaps * 50 / 1000.0f;

    }

    public override float GetSpeed()
    {
        
        return GetDistance() / GetDuration() * 60;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetActivitySummary()
    {
        string activityType = "Swimming";
        return $"{GetDate()} {activityType} ({GetDuration()} minutes): Distance {GetDistance():F2} Km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }
}