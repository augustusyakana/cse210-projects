public class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, string type, string date, int length) : base(type, date, length)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        return distance / GetLength() * 60;
    }
    public override double CalculatePace()
    {
        
        return GetLength() / CalculateDistance();
    }
}