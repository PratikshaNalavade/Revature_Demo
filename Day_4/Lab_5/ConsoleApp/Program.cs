// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(4, 6)
        };

        foreach (Shape shape in shapes)
        {
            shape.Draw();
            Console.WriteLine($"Area: {shape.CalculateArea()}");

            if (shape is ITransformable transformable)
            {
                transformable.Scale(2);
                transformable.Rotate(45);
            }

            Console.WriteLine();
        }
    }
}

