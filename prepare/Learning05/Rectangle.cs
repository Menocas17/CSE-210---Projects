using System.Runtime.InteropServices;

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public Rectangle(double lenght, double width, string color): base(color)
    {
        _lenght = lenght;
        _width = width;
    }

    public override double GetArea()
    {
        return _lenght * _width;
    }
}