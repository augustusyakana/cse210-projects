public class Goal
{
    protected string tracker = "[ ]";
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

    public string getName()
    {
        return _name;
    }

    public string getDescription()
    {
        return _description;
    }

    public virtual string AssembleGoal()
    {
        if (_complete)
        {
            tracker = "[X]";
            return $"{tracker} {_name} ({_description})";
        } else 
        {
            return $"{tracker} {_name} ({_description})";
        }
        
    }

    public virtual int EarnPoints(int points, int total)
    {
        return points += total;
    }

    public virtual string saveInfo()
    {
        return $"{_type}, {_name}, {_description}, {_basePoints}, {_complete}";
    }
}