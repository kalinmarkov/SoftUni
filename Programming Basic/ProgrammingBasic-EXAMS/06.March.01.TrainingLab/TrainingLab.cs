using System;

class TrainingLab
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double placesA = Math.Truncate((a * 100) / 120);
        double placesB = Math.Truncate(((b * 100) - 100) / 70);

        double result = placesA * placesB - 3;

        Console.WriteLine(result);
    }
}

