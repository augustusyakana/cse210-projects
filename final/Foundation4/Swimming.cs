public class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, string type, string date, int length) : base(type, date, length)
    {
        _laps = laps;
    }

    public override string CalculateDistance()
    {
        return $"{_laps * 50 / 1000 * 0.62}";
    }
    public override string CalculateSpeed()
    {
        string dstnce = CalculateDistance();
        int distance = int.Parse(dstnce);
        return $"{distance / GetLength() * 60}";
    }
    public override string CalculatePace()
    {
        string dstnce = CalculateDistance();
        int distance = int.Parse(dstnce);
        return $"{GetLength() / distance}";
    }
}