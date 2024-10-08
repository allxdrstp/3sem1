using System;

class Point
{
    private int x;
    private int y;

    public int X { get { return x; } }
    public int Y { get { return y; } }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class Figure
{
    private Point[] points;
    public string Name { get; set; }

    public Figure(Point p1, Point p2, Point p3)
        : this(new Point[] { p1, p2, p3 }) { }

    public Figure(Point p1, Point p2, Point p3, Point p4)
        : this(new Point[] { p1, p2, p3, p4 }) { }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        : this(new Point[] { p1, p2, p3, p4, p5 }) { }

    private Figure(Point[] points)
    {
        this.points = points;
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public double PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
        }
        return perimeter;
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 0);
        Point p3 = new Point(4, 5);

        Figure triangle = new Figure(p1, p2, p3) { Name = "Triangle" };

        Console.WriteLine($"Figure: {triangle.Name}");
        Console.WriteLine($"Perimeter: {triangle.PerimeterCalculator()}");
    }
}
