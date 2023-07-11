using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();  
        Square s1 = new Square ("Yellow", 2.5f);
        Rectangle r1 = new Rectangle ("Red", 2.5f, 4f);
        Circle c1 = new Circle ("Orange", 2.5f);

        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor() + " " + s.GetArea());
        }

    }
}