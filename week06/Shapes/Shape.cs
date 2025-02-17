using System;

class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    // Getters and Setters
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    // Calculate Area
    public virtual double GetArea()
    {
        return 0;
    }
}