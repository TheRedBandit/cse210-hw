using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Shape> shapes = new List<Shape>();
        
        Square squ = new Square("Red",3);
        Rectange rec = new Rectange("Blue", 4, 5);
        Circle cir = new Circle("Green", 6);

        shapes.Add(squ);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}