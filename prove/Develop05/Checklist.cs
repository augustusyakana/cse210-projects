public class Checklist : Goal
{
    private int _bonusPoints;
    private int _goalLength;
    private int _timesCompleted = 0;

    public Checklist(int bonusPoints, int goalLength, bool complete, string type, string name, string description, int basePoints) : base(complete, type, name, description, basePoints)
    {
        _bonusPoints = bonusPoints;
        _goalLength = goalLength;
    }

    public override string AssembleGoal()
    {
        if (_timesCompleted >= _goalLength)
        {
            tracker = "[X]";
            return $"{tracker} {getName()} ({getDescription()}) -- Currently Completed {_timesCompleted}/{_goalLength}";
        } else 
        {
            return $"{tracker} {getName()} ({getDescription()}) -- Currently Completed {_timesCompleted}/{_goalLength}";
        }
    }

    

    private void updateTimesCompleted()
    {
        _timesCompleted = _timesCompleted + 1;
    }

    public override string saveInfo()
    {
        return $"{getType()}:{getName()},{getDescription()},{getBasePoints()},{getStatus()},{_bonusPoints},{_goalLength},{_timesCompleted}";
    }

    public override int EarnPoints(int total)
    {   
        updateTimesCompleted();
        if (_timesCompleted < _goalLength)
        {
            return base.EarnPoints(total);
        } else
        {
            return base.EarnPoints(total);
        }
        
    }
}