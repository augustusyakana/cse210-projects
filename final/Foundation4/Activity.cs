public class Activity
{
    private string _type;
    private string _date;
    private int _length;
    
    public Activity(string type, string date, int length)
    {
        _type = type;
        _date = date;
        _length = length;
    }

    public string GetActivityType()
    {
        return _type;
    }

    public void SetType(string type)
    {
        _type = type;
    }

    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }

    public virtual double CalculateDistance()
    {
        return 0.00;
    }
   public virtual double CalculateSpeed()
   {
        return 0.00;
   }
   public virtual double CalculatePace()
   {
        return 0.00;
   }
   public virtual string GetSummary()
   {
    return $"{_date} {_type} ({_length} Min) Distance: {Math.Round(CalculateDistance(), 2)} miles, Speed: {Math.Round(CalculateSpeed(), 2)} mph, Pace: {Math.Round(CalculatePace(), 2)} min per mile";
   }
}