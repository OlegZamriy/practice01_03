using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {

        Shape[] shapes = new Shape[]
        {
            new Rectangle(3, 4),
            new Circle(5),
            new RightTriangle(4, 3),
            new Trapezoid(3, 5, 4)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
        }
    }
}
