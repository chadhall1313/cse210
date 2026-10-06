using System.ComponentModel.DataAnnotations;

public class Rectangle : Shape
{
    private double _length = -1;
    private double _width = -1;

    public Rectangle(double length, double width, string color) : base (color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}