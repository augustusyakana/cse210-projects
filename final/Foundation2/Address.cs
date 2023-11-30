public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private int _zipcode;

    public Address(string street, string city, string state, string country, int zipcode)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
        _zipcode = zipcode;
    }

    public string GetStreet()
    {
        return _streetAddress;
    }
    public void SetStreet(string street)
    {
        _streetAddress = street;
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

    public bool CheckIfUSA()
    {
        bool status;
        
        if (_country.ToLower() == "usa")
        {
            status = true;
            return status;
        }
        else
        {
            status = false;
            return status;
        }
    }
    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country} {_zipcode}";
    }
}