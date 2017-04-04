using System;
using System.Collections.Generic;
using System.Linq;

class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public string Print()
    {
        return $"({X}, {Y})";
    }
}

class ClosestTwoPoints
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var points = new List<Point>();

        for (int i = 0; i < n; i++)
        {
            var currentPoint = ReadPoint();
            points.Add(currentPoint);
        }

        var minDistance = double.MaxValue;
        Point firstPointResult = null;
        Point secondPointResult = null;

        for (int first = 0; first < points.Count; first++)
        {
            for (int second = first + 1; second < points.Count; second++)
            {
                var firstPoint = points[first];
                var secondPoint = points[second];

                var distance = Distance(firstPoint, secondPoint);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    firstPointResult = firstPoint;
                    secondPointResult = secondPoint;
                }
            }
        }

        
        Console.WriteLine($"{minDistance:F3}");
        Console.WriteLine(firstPointResult.Print());
        Console.WriteLine(secondPointResult.Print());
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

    public static double Distance(Point first, Point second)
    {
        var squareX = Math.Pow((first.X - second.X), 2);
        var squareY = Math.Pow((first.Y - second.Y), 2);

        var result = Math.Sqrt(squareX + squareY);

        return result;
    }
}

