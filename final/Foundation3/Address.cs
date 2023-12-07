public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private int _zipcode;

    private string _instructions;

    public Address(string street, string city, string state, string country, int zipcode, string instructions)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zipcode = zipcode;
        _instructions = instructions;
    }

    public string GetStreet()
    {
        return _street;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetState()
    {
        return _state;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public int GetZip()
    {
        return _zipcode;
    }
    public void SetZip(int zipcode)
    {
        _zipcode = zipcode;
    }

    private string StringifyAddress()
    {
        return $"{_street} {_city}, {_state} {_country} {_zipcode}\n({_instructions})";
    }

    public string GetAddress()
    {
        return StringifyAddress();
    }
}