public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity, string type, string title, string description, string date, string time): base(type, title, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"WHAT: {GetEventType()}: {GetTitle()}\n{GetDescription()}\nSPEAKER: {_speaker}\nWHEN: {GetDate()} - {GetTime()}\nWHERE: {GetAddress()}\nLIMITED CAPACITY: {_capacity}";
    }
}