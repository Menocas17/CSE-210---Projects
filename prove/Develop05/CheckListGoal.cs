public class CheckListGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonusPoints;


    public CheckListGoal(string name, int points, string description, int target, int bonusPoints) : base(name, points, description)
    {
        _target = target;
        _bonusPoints = bonusPoints;

    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public void SetAmountCompleted()
    {
        _amountCompleted ++;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }


    public override string GetGoalDetails()
    {

        if(GetCompleteDetails() == false)
        {
            return $" [] {GetName()} ({GetDescription()}) -- Currently Complete {_amountCompleted}/{_target} - {GetPoints()} points";
        }

        else
        {
            return $" [X] {GetName()} ({GetDescription()}) -- Currently Complete {_amountCompleted}/{_target} - {GetPoints()} points";
        }
        
    }

     public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{GetName()}/{GetDescription()}/{GetPoints()}/{_target}/{_amountCompleted}/{_bonusPoints}";
    }

}