public class Checklist : Goal
{
    bool bonusTime = false;
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

    private void checkBonusStatus(int total)
    {
        if (_timesCompleted == _goalLength)
        {
            
            tracker = "[X]";
            Console.WriteLine($"\nCongratulations, you earned a Bonus of {_bonusPoints} points.");
            bonusTime = true;
            setStatus(true);
            
            
        }
        else
        {
            Console.WriteLine($"\n{_goalLength - _timesCompleted} times left to earn bonus points.");
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
        checkBonusStatus(total);

        if (bonusTime)
        {
            return base.EarnPoints(total) + _bonusPoints;
        } else
        {
            return base.EarnPoints(total);
        }
        
    }
}