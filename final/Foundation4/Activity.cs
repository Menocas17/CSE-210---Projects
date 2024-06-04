using System.Globalization;
using System.Runtime.CompilerServices;

public  abstract class Activity
{
    private float _duration;
    private string _date;

    public Activity()
    {

    }

    public float GetDuration()
    {
        return _duration;
    }

    public string GetDate()
    {
        return _date;
    }

    public Activity (float duration, string date)
    {
        _duration = duration;
        _date = date;
    }

    public abstract float GetPace();

    public abstract float GetSpeed();
   
    public abstract float GetDistance ();

    public virtual string GetActivitySummary()
    {
        string activityType = "activty";
        return $"{GetDate()} {activityType} ({GetDuration()}): Distance {GetDistance()}, Speed {GetSpeed()}, Pace {GetPace()}";
    }
}