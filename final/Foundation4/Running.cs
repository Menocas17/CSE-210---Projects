public class Running : Activity 
{
    private float _distance;

    public Running (int duration, string date, float distance) : base (duration, date)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;

    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }

    public override float GetSpeed()
    {
        return (_distance / GetDuration ()) * 60;
    }   

    public override string GetActivitySummary()
    {
        string activityType = "Running";
        return $"{GetDate()} {activityType} ({GetDuration()} minutes): Distance {GetDistance():F2} Km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    } 
}