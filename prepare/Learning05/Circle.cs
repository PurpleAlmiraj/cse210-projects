public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {
        return _radius * _radius * Math.PI;
    }
}
