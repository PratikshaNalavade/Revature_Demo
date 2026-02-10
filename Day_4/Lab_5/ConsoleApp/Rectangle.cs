using System;

public class Rectangle : Shape, ITransformable
{
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Rectangle(double width, double height) : base("Rectangle")
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public void Scale(double factor)
    {
        Width *= factor;
        Height *= factor;
        Console.WriteLine($"Rectangle scaled. New size: {Width} x {Height}");
    }

    public void Rotate(double angle)
    {
        Console.WriteLine($"Rectangle rotated by {angle} degrees.");
    }
}
