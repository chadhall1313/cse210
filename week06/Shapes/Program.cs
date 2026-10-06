using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(12.2, "blue");
        Square square = new Square(7.123, "orange");
        Rectangle rectangle = new Rectangle(11, 4.3, "purple");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle);
        shapes.Add(square);
        shapes.Add(rectangle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine($"Color: {shape.GetColor()}");
        }
    }
}