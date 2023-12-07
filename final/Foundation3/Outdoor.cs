public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string weather, string type, string title, string description, string date, string time): base(type, title, description, date, time)
    {
        _weather = weather;
    }
    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"WHAT: {GetEventType()}: {GetTitle()}\n{GetDescription()}\nWHEN: {GetDate()} - {GetTime()}\nWHERE: {GetAddress()}\nForecast: {_weather}";
    }
}