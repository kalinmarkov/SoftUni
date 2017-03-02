using System;

class TriangleArea
{
    static void Main()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        double a = Math.Abs(x3 - x2);
        double h = Math.Abs(y2 - y1);
        double area = a * h / 2;

        Console.WriteLine(area);
    }
}

