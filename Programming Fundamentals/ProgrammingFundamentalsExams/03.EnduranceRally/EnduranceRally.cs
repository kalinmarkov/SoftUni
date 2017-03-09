using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var drivers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var trackZones = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse).ToArray();
        var checkpoint = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        foreach (var driver in drivers)
        {
            double fuel = driver.First();
            for (int i = 0; i < trackZones.Length; i++)
            {
                if (checkpoint.Contains(i))
                {
                    fuel += trackZones[i];
                }
                else
                {
                    fuel -= trackZones[i];
                }

                if (fuel <= 0)
                {
                    Console.WriteLine($"{driver} - reached {i}");
                    break;
                }
            }

            if (fuel > 0)
            {
                Console.WriteLine($"{driver} - fuel left {fuel:F2}");
            }
        }
    }
}

