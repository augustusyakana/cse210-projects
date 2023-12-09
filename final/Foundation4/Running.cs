public class Running : Activity
{
    private double _distance;

    public Running(double distance, string type, string date, int length) : base(type, date, length)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return (_distance / GetLength()) * 60;
    }
    public override double CalculatePace()
    {
        return GetLength() / _distance;
    }
}