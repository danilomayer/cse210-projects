using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
    }
}

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

}

Fraction f1 = new Fraction();
Fraction f2 = new Fraction(1, 4);
Fraction f3 = new Fraction(2, 5);