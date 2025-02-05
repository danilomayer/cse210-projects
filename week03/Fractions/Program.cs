using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");


        Fraction f1 = new Fraction(1, 1);
        Fraction f2 = new Fraction(5, 1);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        // Display initial values
        Console.WriteLine($"f1: {f1.GetFractionString()}");
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine($"f2: {f2.GetFractionString()}");
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine($"f3: {f3.GetFractionString()}");
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine($"f4: {f4.GetFractionString()}");
        Console.WriteLine(f4.GetDecimalValue());
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

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int Top
    {
        get { return _top; }
        set { _top = value; }
    }

    public int Bottom
    {
        get { return _bottom; }
        set { _bottom = value; }
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
