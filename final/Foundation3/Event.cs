using System.Net.Sockets;

public class Event
{
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string type, string title, string description, string date, string time)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetTime()
    {
        return _time;
    }
    public void SetTime(string time)
    {
        _time = time;
    }

    public string GetEventType()
    {
        return _type;
    }

    public void SetAddress(string street, string city, string state, string country, int zipcode, string instructions)
    {
        Address address = new Address(street, city, state, country, zipcode, instructions);
        _address = address;
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
    public string GetStandardDetails()
    {
        //need to add DisplayAddress method in the string
        return $"EVENT: {_title} ({_date} - {_time})\n{_description}\nWHERE: {_address.GetAddress()}";
    }
    public virtual string GetFullDetails()
    {
        //add DisplayAddress method at the end of the string
        return $"{_type}: {_title}\n{_description}\n{_date} - {_time}\n{_address.GetAddress()}";
    }

    public string GetShortDescription()
    {
        return $"{_type} - {_title} ({_date})";
    }

}