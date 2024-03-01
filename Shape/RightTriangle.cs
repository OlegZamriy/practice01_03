using System;

public class RightTriangle : Shape
{
    public double Base { get; }
    public double Height { get; }

    public RightTriangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}
