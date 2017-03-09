using System;

namespace _11.ConvertSpeedUnits
{
    public class ConvertSpeedUnits
    {
        public static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float totalSeconds = (hours * 3600f) + (minutes * 60f) + seconds;

            float metersPerSeconds = distanceInMeters / totalSeconds;
            float kilometerPerHour = (distanceInMeters / 1000) / (totalSeconds / 3600);
            float milesPerHours = ((float)distanceInMeters / 1609) / (totalSeconds / 3600);

            Console.WriteLine("{0:0.#######}", metersPerSeconds);
            Console.WriteLine("{0:0.#######}", kilometerPerHour);
            Console.WriteLine("{0:0.#######}", milesPerHours);
        }
    }
}
