using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Circle s1 = new Circle("Red", 4);
        shapes.Add(s1);
        Rectangle s2 = new Rectangle("Yellow", 3, 6);
        shapes.Add(s2);
        Square s3 = new Square("Blue", 5);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The area of the {color} shape is {area}. ");
        }
    }
}