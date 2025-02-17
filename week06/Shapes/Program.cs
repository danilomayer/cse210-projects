using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(5, "blue");
        Console.WriteLine($"New square area: {square1.GetArea()}, color: {square1.GetColor()}");

        Rectangle rectangle1 = new Rectangle(5, 2, "yellow");
        Console.WriteLine($"New rectangle area: {rectangle1.GetArea()}, color: {rectangle1.GetColor()}");

        Circle circle1 = new Circle(5, "Green");
        Console.WriteLine($"New circle area: {circle1.GetArea()}, color: {circle1.GetColor()}");
    }
}