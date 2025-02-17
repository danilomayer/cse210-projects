using System;

class Square : Shape
{
    private double _side;

    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    // Getters and Setters
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }

    // Calculate Area
    public override double GetArea()
    {
        return _side * _side;
    }
}