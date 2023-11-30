using System.Diagnostics;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _totalPrice = 0.00;
    private double _shippingCost = 0;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public string GetTotalCost()
    {
        GetTotalPrice();
        return $"\nSubTotal: ${_totalPrice.ToString("0.00")}\nShipping/Handling: ${_shippingCost.ToString("0.00")}\nTotal Price: ${(_totalPrice + _shippingCost).ToString("0.00")}";
    }

    public void GetProducts()
    {
        Console.WriteLine("\nProducts:");
        foreach(Product product in _products)
        {
            Console.WriteLine(product.GetProductDetails());
        }
        
    }
    public void AddProducts(Product product)
    {
        _products.Add(product);
    }
    public void GetCustomerInfo()
    {
        Console.WriteLine("\nCustomer Information: ");
        Console.WriteLine(_customer.GetCustomerInformation());
    }

    public void GetTotalPrice()
    {
        if (_customer.CheckLocationUSA() == true)
        {
            _shippingCost = 5.00;
        }
        else 
        {
            _shippingCost = 35.00;
        }

        foreach (Product product in _products)
        {
            _totalPrice += product.GetTotalPrice();
        }
        
    }
    public void GetPackingLabel()
    {   
        Console.WriteLine("\n(Packing Label)");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetName()} - ID: {product.GetID()}");
        }
    }
    public void GetShippingLabel()
    {
        Console.WriteLine("\n(Shipping Label)");
        Console.WriteLine($"Ship To: \n{_customer.GetCustomerInformation()}");
    }
}