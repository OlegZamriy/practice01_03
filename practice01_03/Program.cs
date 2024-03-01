using System;

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
        {
            new Rectangle(5, 4),
            new Circle(3),
            new RightTriangle(6, 8),
            new Trapezoid(4, 6, 5)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
        }
    }
}
