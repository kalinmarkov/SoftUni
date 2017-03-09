using System;
using System.Globalization;

class SinoTheWalker
{
    static void Main()
    {
        DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
        int steps = int.Parse(Console.ReadLine()) % (60 * 60 * 24);
        int secondsPerStep = int.Parse(Console.ReadLine()) % (60 * 60 * 24);
        int additionalTime = steps * secondsPerStep;
        var totalTime = time.AddSeconds(additionalTime).ToString("HH:mm:ss");
        Console.WriteLine($"Time Arrival: {totalTime}");
    }
}