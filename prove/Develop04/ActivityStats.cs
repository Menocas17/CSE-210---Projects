using System.Dynamic;

public class ActivityStats
{
    private int _timeSpent;
    private int _usageCount;

    public ActivityStats(int timeSpent)
    {
        _timeSpent = timeSpent;
        _usageCount = 1;
    }

    public int GetTimeSpent()
    {
        return _timeSpent;
    }

    public int GetUsageCount()
    {
        return _usageCount;
    }

    public void UpdateTimeSpent(int timeSpent)
    {
        _timeSpent += timeSpent;
    }

    public void UpdateUsageCount()
    {
        _usageCount ++;
    }
}