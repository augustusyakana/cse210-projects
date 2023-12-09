public class Activity
{
    private string _date;
    private int _length;
    
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
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

    public virtual string CalculateDistance()
    {
        
    }
}