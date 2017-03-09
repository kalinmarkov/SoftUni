using System;
using System.Globalization;
using System.Numerics;

class SinoTheWalker
{
    static void Main()
    {
        var timeFormat = "HH:mm:ss";
        var startingTime = DateTime.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);
        var numberOfsteps = long.Parse(Console.ReadLine());
        var secondsPerStep = long.Parse(Console.ReadLine());

        ulong initialSeconds = (ulong)startingTime.Hour * 60 * 60 + (ulong)startingTime.Minute * 60 
            + (ulong)startingTime.Second;
        var secondsToAdd = numberOfsteps * secondsPerStep;
        var totalSeconds = (ulong)initialSeconds + (ulong)secondsToAdd;
        var seconds = totalSeconds % 60;
        var totalMinutes = totalSeconds / 60;
        var minutes = totalMinutes % 60;
        var totalHours = totalMinutes / 60;
        var hours = totalHours % 24;

        Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}" );
    }
}

