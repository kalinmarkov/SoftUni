using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        var timeFormat = "HH:mm:ss";
        var startingTime = DateTime.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);

        var numberOfsteps = decimal.Parse(Console.ReadLine());
        var secondsPerStep = decimal.Parse(Console.ReadLine());

        var secondsInDay = 60 * 60 * 24;
        var totalSecondsNeeded = (int)(numberOfsteps * secondsPerStep % secondsInDay);

        var arrivalTime = startingTime.AddSeconds(totalSecondsNeeded);

        Console.WriteLine($"Time Arrival: {arrivalTime.ToString(timeFormat)}");
    }
}

