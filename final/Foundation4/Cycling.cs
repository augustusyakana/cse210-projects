public class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, string type, string date, int length) : base(type, date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed * GetLength() / 60;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        return GetLength() / distance;
    }
}