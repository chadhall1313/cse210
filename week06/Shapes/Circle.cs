using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _radius = -1;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }


    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}