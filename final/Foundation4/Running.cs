public class Running : Activity
{
    private int _distance;

    public Running(int distance, string type, string date, int length) : base(type, date, length)
    {
        _distance = distance;
    }

    public override string CalculateDistance()
    {
        return $"{_distance}";
    }
    public override string CalculateSpeed()
    {
        return $"{_distance / GetLength() * 60}";
    }
    public override string CalculatePace()
    {
        return $"{GetLength() / _distance}";
    }
}