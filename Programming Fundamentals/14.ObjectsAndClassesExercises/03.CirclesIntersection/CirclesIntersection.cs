using System;
using System.Linq;

class Circle
{
    public int X { get; set; }

    public int Y { get; set; }

    public int Radius { get; set; }

    public static Circle ReadInput()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var circle = new Circle()
        {
            X = input[0],
            Y = input[1],
            Radius = input[2]
        };
        return circle;
    }

    public static bool IsIntersect(Circle c1, Circle c2)
    {
        var distanceBetweenCenters = Math.Sqrt(Math.Pow((c1.X - c2.X), 2) + Math.Pow((c1.Y - c2.Y), 2));
        if (distanceBetweenCenters <= (c1.Radius + c2.Radius))
        {
            return true;
        }
        return false;
    }
}
class CirclesIntersection
{
    static void Main()
    {
        var firstCircle = Circle.ReadInput();
        var secondCircle = Circle.ReadInput();
        if (Circle.IsIntersect(firstCircle, secondCircle))
        {

            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

