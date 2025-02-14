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

    public Customer(string name, A
    ddress address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }
}