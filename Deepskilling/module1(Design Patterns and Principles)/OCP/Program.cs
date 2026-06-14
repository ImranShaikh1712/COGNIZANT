using System;

abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius = 5;
    public override double Area()
    {
        return 3.14 * Radius * Radius;
    }
}

class Program
{
    static void Main()
    {
        Shape s = new Circle();
        Console.WriteLine(s.Area());
    }
}
