using System;

class PointInFigure
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int x1 = 4;      int x3 = 2;     int x5 = 4;
        int y1 = -5;     int y3 = -3;    int y5 = 1;
        int x2 = 10;     int x4 = 12;    int x6 = 10;
        int y2 = -3;     int y4 = 1;     int y6 = 3;

        if ((x1 <= x && x <= x2 && y1 <= y && y <= y2) ||
            (x3 <= x && x <= x4 && y3 <= y && y <= y4) ||
            (x5 <= x && x <= x6 && y5 <= y && y <= y6))
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
    }
}

