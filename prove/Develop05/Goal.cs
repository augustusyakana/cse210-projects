using System.Dynamic;

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

    public void setStatus(bool status)
    {
        _complete = status;
        tracker = "[X]";
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

    public bool getStatus()
    {
        return _complete;
    }

    public int getBasePoints()
    {
        return _basePoints;
    }

    public string getType()
    {
        return _type;
    }

    public virtual int EarnPoints(int total)
    {
        return _basePoints += total;
    }

    public virtual string saveInfo()
    {
        return $"{_type}:{_name},{_description},{_basePoints},{_complete}";
    }
}