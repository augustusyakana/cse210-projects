public class Reception : Event
{
    
    private string _rsvpStatement;

    public Reception(string rsvpStatement, string type, string title, string description, string date, string time): base(type, title, description, date, time)
    {
        
        _rsvpStatement = rsvpStatement;
    }
    public string GetStatement()
    {
        return _rsvpStatement;
    }
    public void SetStatement(string rsvpStatement)
    {
        _rsvpStatement = rsvpStatement;
    }

    public override string GetFullDetails()
    {
        return $"WHAT: {GetEventType()} - {GetTitle()}\n{GetDescription()}\nWHEN: {GetDate()} - {GetTime()}\nWHERE: {GetAddress()}\n\n{_rsvpStatement}";
    }
}