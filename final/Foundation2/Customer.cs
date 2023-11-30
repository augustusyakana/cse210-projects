public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetNamer(string name)
    {
        _name = name;
    }

    public bool CheckLocationUSA()
    {
        return _address.CheckIfUSA();
    }

    public void AddCustomerAddress(string street, string city, string state, string country, int zipcode)
    {
        Address address = new Address(street, city, state, country, zipcode);
        _address = address;
    }
    public string GetCustomerInformation()
    {
        return $"{_name}\n{_address.GetAddress()}";
    }
}