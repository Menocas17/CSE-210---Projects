using System.ComponentModel;

public class Goal 
{
    private string _name;
    private int _points;
    private string _description;
    private bool _isComplete = false;

    public Goal(string name, int points, string description)
    {
        _name = name;
        _points = points;
        _description = description;
    }

    public Goal()
    {

    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetDescription()
    {
        return _description;
    }

    public bool GetCompleteDetails()
    {
        return _isComplete;
    }

    public void IsComplete()
    {
        _isComplete = true;
    }

    public virtual string GetGoalDetails()
    {
        if(GetCompleteDetails() == false)
        {
            return $" [] {GetName()} ({GetDescription()}) - {GetPoints()} points";
        }

        else
        {
            return $" [X] {GetName()} ({GetDescription()}) - {GetPoints()} points";
        }
        
    
    }
    public virtual string GetStringRepresentation()
    {
        return $"{GetName()}/{GetDescription()}/{GetPoints()}";
    }




}