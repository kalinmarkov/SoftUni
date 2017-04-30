using System;

class HornetWings
{
    static void Main()
    {
        var wingFlaps = long.Parse(Console.ReadLine());
        var distancePer1000WingFlaps = double.Parse(Console.ReadLine());
        var endurance = long.Parse(Console.ReadLine());

        var totalDistance = (wingFlaps / 1000) * distancePer1000WingFlaps;

        var movingTime = wingFlaps / 100;
        var restTime = (wingFlaps / endurance) * 5;

        Console.WriteLine($"{totalDistance:F2} m.");
        Console.WriteLine($"{movingTime + restTime} s.");
    }
}

