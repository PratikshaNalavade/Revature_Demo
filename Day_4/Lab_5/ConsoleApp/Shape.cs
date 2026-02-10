using System;

public abstract class Shape
{
    public string Name { get; protected set; }

    protected Shape(string name)
    {
        Name = name;
    }

    // Abstract method (must be implemented)
    public abstract double CalculateArea();

    // Virtual method (optional override)
    public virtual void Draw()
    {
        Console.WriteLine($"Drawing {Name}");
    }
}
