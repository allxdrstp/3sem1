using System;

class Rectangle
{
    private double sideA;
    private double sideB;

    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    private double CalculateArea()
    {
        return sideA * sideB;
    }

    private double CalculatePerimeter()
    {
        return 2 * (sideA + sideB);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter side A: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Enter side B: ");
        double sideB = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(sideA, sideB);

        Console.WriteLine($"Area: {rectangle.Area}");
        Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
    }
}
