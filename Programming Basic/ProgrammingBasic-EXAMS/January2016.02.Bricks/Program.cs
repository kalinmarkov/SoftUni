using System;

class Program
{
    static void Main()
    {
        double bricks = double.Parse(Console.ReadLine());
        double workers = double.Parse(Console.ReadLine());
        double carVolume = double.Parse(Console.ReadLine());
        double course = bricks / (workers * carVolume);

        Console.WriteLine(Math.Ceiling(course));

    }
}

