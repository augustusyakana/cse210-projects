public class Checklist : Goal
{
    private bool _bonus;
    private int _bonusPoints;
    private int _goalLength;
    private int _timesCompleted = 0;

    public Checklist(bool bonus, int bonusPoints, int goalLength, bool complete, string type, string name, string description, int basePoints) : base(complete, type, name, description, basePoints)
    {
        _bonus = bonus;
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
}