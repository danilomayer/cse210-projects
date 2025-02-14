using System;

class Program
{
    static void Main(string[] args)
    { }
}

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return _street + "\n" + _city + ", " + _state + "\n" + _country;
    }

}

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetCustomerDetails()
    {
        return "Customer: " + _name + "\n" + _address.GetFullAddress();
    }
}

class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quality;

    public Product(string name, string productId, double price, int quality)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quality = quality;
    }

    public double GetTotalCost()
    {
        return _price * _quality;
    }

    public string GetProductDetail()
    {
        return _name + " (ID: " + _productId + ")";
    }
}

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetProductDetail() + "\n";
        }
        return label;
    }
}