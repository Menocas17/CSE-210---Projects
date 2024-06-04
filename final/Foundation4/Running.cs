public class Running : Activity 
{
    private float _distance;

    public Running (float duration, string date, float distance) : base (duration, date)
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
        return $"{GetDate()} {activityType} ({GetDuration()}): Distance {GetDistance()}, Speed {GetSpeed()}, Pace {GetPace()}";
    } 
}