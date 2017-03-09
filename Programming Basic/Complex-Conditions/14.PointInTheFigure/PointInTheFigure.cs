using System;

class PointInTheFigure
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int x1 = 0;
        int x2 = 3 * h;
        int x3 = h;
        int x4 = 2 * h;
        int y1 = 0;
        int y2 = h;
        int y3 = h;
        int y4 = 4 * h;

        if ((((x == x1 || x == x2) && (y > y1 && y < y2)) ||
             ((x == x3 || x == x4) && (y > y3 && y < y4)) ||
             ((y == y1 || y == y2) && (x > x1 && x < x2)) ||
             ((y == y3 || y == y4) && (x > x3 && x < x4)) ||
             ((x == x1 || x == x2) && (y == y1 || y == y2)) ||
             ((x == x3 || x == x4) && (y == y3 || y == y4))) !=
             ((h < x && x < 2 * h) && y == h))
        {
            Console.WriteLine("border");
        }

        else if (((x > x1 && x < x2 && y > y1 && y < y2) ||
            (x > x3 && x < x4 && y > y3 && y < y4)) || ((h < x && x < 2 * h) && y == h))
        {
            Console.WriteLine("inside");
        }

        else if ((x < x1 || x > x2 || y < y1 || y > y2) ||
            (x < x3 || x > x4 || y < y3 || y > y4))
        {
            Console.WriteLine("outside");
        }

    }
}

