using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;

class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public static Point ReadPointCoordinates()
    {
        var coordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var p = new Point() { X = coordinates[0], Y = coordinates[1] };
        return p;
    }

    public static Point[] ReadArrayOfPoints()
    {
        var n = int.Parse(Console.ReadLine());
        var points = new Point[n];
        for (int i = 0; i < n; i++)
        {
            points[i] = ReadPointCoordinates();
        }
        return points;
    }

    public static double CalculateDistance(Point pointOne, Point pointTwo)
    {
        var a = pointOne.X - pointTwo.X;
        var b = pointOne.Y - pointTwo.Y;
        var sum2 = a * a + b * b;
        var distance = Math.Sqrt(sum2);
        return distance;
    }

    public static Point[] FindNearestPoints(Point[] points)
    {
        var minDistance = double.MaxValue;
        var nearestPoints = new Point[] { };
        for (int first = 0; first < points.Length; first++)
        {
            for (int second = first + 1; second < points.Length; second++)
            {
                var p1 = points[first];
                var p2 = points[second];
                var dist = Point.CalculateDistance(p1, p2);
                if (dist < minDistance)
                {
                    minDistance = dist;
                    nearestPoints = new Point[] { p1, p2 };
                }
            }
        }

        return nearestPoints;
    }

    public override string ToString()
    {
        return String.Format("({0}, {1})", this.X, this.Y);
    }
}
class Program
{
    static void Main()
    {
        var points = Point.ReadArrayOfPoints();
        var nearestPoints = Point.FindNearestPoints(points);

        Console.WriteLine($"{Point.CalculateDistance(nearestPoints[0], nearestPoints[1]):f3}");
        Console.WriteLine(nearestPoints[0]);
        Console.WriteLine(nearestPoints[1]);
    }

}

