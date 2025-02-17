using System;

class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    // Getters and Setters
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * (_radius * _radius);
    }
}