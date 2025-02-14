using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Addresses
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Elm St", "New York", "NY", "USA");

        // Create Customers
        Customer customer1 = new Customer("Alice", address1);
        Customer customer2 = new Customer("Bob", address2);

        // Create Products
        Product product1 = new Product("Laptop", "L001", 1000, 2);
        Product product2 = new Product("Mouse", "M001", 20, 5);
        Product product3 = new Product("Keyboard", "K001", 50, 3);
        Product product4 = new Product("Monitor", "M002", 200, 1);

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display Order Details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
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
    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetCustomerDetails();
    }
}