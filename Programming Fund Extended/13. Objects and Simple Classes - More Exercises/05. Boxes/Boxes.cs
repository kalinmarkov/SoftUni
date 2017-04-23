using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public static int CalDistance(Point firstPoint, Point seconPoint)
    {
        double sideA = firstPoint.X - seconPoint.X;
        double sideB = firstPoint.Y - seconPoint.Y;

        int distance = (int)Math.Sqrt((sideA * sideA) + (sideB * sideB));

        return distance;
    }
}

public class Box
{
    public int Width { get; set; }

    public int Height { get; set; }

    public int Perimeter { get; set; }

    public int Area { get; set; }

    public static int CalculatePerimeter(int width, int height)
    {
        return (2 * width) + (2 * height);
    }

    public static int CalculateArea(int width, int height)
    {
        return width * height;
    }
}

public class Boxes
{
    public static void Main()
    {
        var boxes = new List<Box>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var tokens = input
                .Split(" | :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var upperLeft = new Point { X = tokens[0], Y = tokens[1] };
            var upperRight = new Point { X = tokens[2], Y = tokens[3] };
            var bottomLeft = new Point { X = tokens[4], Y = tokens[5] };
            var bottomRight = new Point { X = tokens[6], Y = tokens[7] };

            var width = Point.CalDistance(upperLeft, upperRight);
            var hight = Point.CalDistance(upperLeft, bottomLeft);
            var perimeter = Box.CalculatePerimeter(width, hight);
            var area = Box.CalculateArea(width, hight);

            var box = new Box { Height = hight, Width = width, Area = area, Perimeter = perimeter };
            boxes.Add(box);
            
        }

        foreach (var box in boxes)
        {
            Console.WriteLine($"Box: {box.Width}, {box.Height}");
            Console.WriteLine($"Perimeter: {box.Perimeter}");
            Console.WriteLine($" Area: {box.Area}");
        }
    }
}

