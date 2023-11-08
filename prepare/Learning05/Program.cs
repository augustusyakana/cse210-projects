using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string squarColor = "Blue";
        double side = 6;
        Square square = new Square(squarColor, side);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        string RecColor = "White";
        double length = 8;
        double width = 9;
        Rectangle rectangle = new Rectangle(RecColor, length, width);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        string CirColor = "Black";
        double radius = 5.7;
        Circle circle = new Circle(CirColor, radius);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle);
        shapes.Add(square);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"\nCOLOR: {color}\nAREA: {area}");
        }
    }
    
}