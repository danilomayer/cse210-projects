using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square(5, "Yellow");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle(5, 2, "Green");
        shapes.Add(s2);

        Circle s3 = new Circle(5, "Blue");
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area {area}.");
        }
    }
}