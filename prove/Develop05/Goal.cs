public class Goal
{
    private bool _complete;
    private string _type;
    private string _name;
    private string _description;
    private int _basePoints;

    public Goal(bool complete, string type, string name, string description, int basePoints)
    {
        _complete = complete;
        _type = type;
        _name = name;
        _description = description;
        _basePoints = basePoints;
    }

    public virtual void EarnPoints(int points)
    {
        points += _basePoints;
    }
}