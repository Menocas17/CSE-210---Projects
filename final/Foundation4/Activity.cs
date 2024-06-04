using System.Globalization;
using System.Runtime.CompilerServices;

public  abstract class Activity
{
    private int _duration;
    private string _date;

    public Activity()
    {

    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetDate()
    {
        return _date;
    }

    public Activity (int duration, string date)
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
        return $"{GetDate()} {activityType} ({GetDuration()} minutes): Distance {GetDistance():F2} Km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }
}