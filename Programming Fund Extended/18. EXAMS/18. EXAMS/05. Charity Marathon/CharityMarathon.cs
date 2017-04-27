using System;

class CharityMarathon
{
    static void Main()
    {
        int marathonDays = int.Parse(Console.ReadLine());
        int numberOfRunners = int.Parse(Console.ReadLine());
        int averageNumberOfLaps = int.Parse(Console.ReadLine());
        int lapLenght = int.Parse(Console.ReadLine());
        int trackCapacity = int.Parse(Console.ReadLine());
        decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

        if (trackCapacity * marathonDays < numberOfRunners)
        {
            numberOfRunners = trackCapacity * marathonDays;
        }

        ulong totalMeters = (ulong)averageNumberOfLaps * (ulong)numberOfRunners * (ulong)lapLenght;
        decimal totalKilometers = totalMeters / 1000.0m;

        decimal totalMoney = totalKilometers * moneyPerKilometer;

        Console.WriteLine($"Money raised: {totalMoney:f2}");
    }
}

