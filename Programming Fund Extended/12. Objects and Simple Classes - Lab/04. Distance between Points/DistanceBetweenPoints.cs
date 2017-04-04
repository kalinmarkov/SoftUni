using System;
using System.Linq;

class Point
{
    public double X { get; set; }

    public double Y { get; set; }

}

class DistanceBetweenPoints
{
    static void Main()
    {
        Point firstPoint = ReadPoint();
        Point secondPoint = ReadPoint();

        var result = Distance(firstPoint, secondPoint);
        Console.WriteLine($"{result:F3}");
    }

    private static Point ReadPoint()
    {
        var pointsParts = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var point = new Point()
        {
            X = pointsParts[0],
            Y = pointsParts[1]
        };
        return point;
    }

    public static double Distance (Point first, Point second)
    {
        var squareX = Math.Pow((first.X - second.X), 2);
        var squareY = Math.Pow((first.Y - second.Y), 2);

        var result = Math.Sqrt(squareX + squareY);

        return result;
    }
}

