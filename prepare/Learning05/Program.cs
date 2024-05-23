using System;

class Program
{
    static void Main(string[] args)
    {
        Shape rectangle = new Rectangle(3, 5, "red");
        Shape circle = new Circle(5, "green");
        Shape square = new Square("black", 4);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"The color is {shape.GetColor()} and the area is {shape.GetArea()}");
        }

    }
}