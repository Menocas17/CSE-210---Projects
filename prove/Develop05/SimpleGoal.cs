public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points, string description) : base(name, points, description)
    {

    }

     public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()}/{GetDescription()}/{GetPoints()}/{GetCompleteDetails()}";
    }



}
