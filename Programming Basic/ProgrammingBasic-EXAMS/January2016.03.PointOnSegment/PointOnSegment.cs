using System;

class PointOnSegment
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int point = int.Parse(Console.ReadLine());
        int minDistance = 0;
        if ((first <= point && point <= second) || (first > point && point > second))
        {
            minDistance = Math.Min(Math.Abs(point - first), Math.Abs(second - point));
            Console.WriteLine("in");
            Console.WriteLine(minDistance);
        }
        else
        {
            minDistance = Math.Min(Math.Abs(point - first), Math.Abs(second - point));
            Console.WriteLine("out");
            Console.WriteLine(Math.Abs(minDistance));
        }
    }
}

