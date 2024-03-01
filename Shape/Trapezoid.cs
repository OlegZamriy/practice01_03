using System;

public class Trapezoid : Shape
{
    public double Base1 { get; }
    public double Base2 { get; }
    public double Height { get; }

    public Trapezoid(double base1, double base2, double height)
    {
        Base1 = base1;
        Base2 = base2;
        Height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * (Base1 + Base2) * Height;
    }
}
