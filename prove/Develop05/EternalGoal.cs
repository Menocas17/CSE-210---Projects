public class EternalGoal : Goal
{
    public EternalGoal(string name, int points, string description) : base(name, points, description)
    {

    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()}/{GetDescription()}/{GetPoints()}/{GetCompleteDetails()}";
    }

    
}
