public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public int GetID()
    {
        return _id;
    }
    public void SetID(int id)
    {
        _id = id;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetProductDetails()
    {
        return $"Product Name: {_name}\nProduct ID: {_id}\nPrice: ${_price}\nQuantity: {_quantity}\nTotal: ${GetTotalPrice()}";
    }
}