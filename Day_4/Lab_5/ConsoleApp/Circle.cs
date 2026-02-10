using System;

public class Circle : Shape, ITransformable
{
    public double Radius { get; private set; }

    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public void Scale(double factor)
    {
        Radius *= factor;
        Console.WriteLine($"Circle scaled. New radius: {Radius}");
    }

    public void Rotate(double angle)
    {
        Console.WriteLine($"Circle rotated by {angle} degrees (no visual change).");
    }
}
