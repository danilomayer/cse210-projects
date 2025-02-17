using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(5, "blue");
        Console.WriteLine($"New square area: {square1.GetArea()}, color: {square1.GetColor()}");
    }
}