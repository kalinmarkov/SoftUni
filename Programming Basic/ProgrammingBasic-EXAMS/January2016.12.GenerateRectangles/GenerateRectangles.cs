using System;

class GenerateRectangles
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        if (4 * n * n >= m)
        {
            for (int y2 = -n; y2 <= n; y2++)
            {
                for (int y1 = -n; y1 < y2; y1++)
                {
                    for (int x2 = -n; x2 <= n; x2++)
                    {
                        for (int x1 = -n; x1 <= x2; x1++)
                        {
                            int area = (y2 - y1) * (x2 - x1);
                            if (x1 < x2 && y1 < y2)
                            {
                                if ((x2 - x1) * (y2 - y1) >= m)
                                {
                                    Console.WriteLine($"({x1}, {y1}) ({x2}, {y2}) -> {area}");
                                }
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No");
            return;

        }
    }
}

