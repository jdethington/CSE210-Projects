using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("blue", 5);
        // string color = square.GetColor();
        // double area = square.GetArea();
        // Console.WriteLine($"The color is {color} and the area is {area}");

        Rectangle rectangle = new Rectangle("Orange", 5, 3);
        // color = rectangle.GetColor();
        // area = rectangle.GetArea();
        // Console.WriteLine($"The color is {color} and the area is {area}");

        Circle circle = new Circle("Green", 2);
        // color = circle.GetColor();
        // area = circle.GetArea();
        // Console.WriteLine($"The color is {color} and the area is {area}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The color is {shape.GetColor()} and the area is {shape.GetArea()}");
        }
    }
}