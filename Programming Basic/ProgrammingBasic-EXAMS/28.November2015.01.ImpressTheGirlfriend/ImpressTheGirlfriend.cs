using System;

class ImpressTheGirlfriend
{
    static void Main()
    {
        decimal amountOfRubles = decimal.Parse(Console.ReadLine()) / 100 * 3.5m;
        decimal amountOfDollars = decimal.Parse(Console.ReadLine()) * 1.5m;
        decimal amountOfEuro = decimal.Parse(Console.ReadLine()) * 1.95m;
        decimal amountOfB = decimal.Parse(Console.ReadLine()) / 2.0m;
        decimal amountOfM = decimal.Parse(Console.ReadLine());
        decimal maxPrice = 0.0m;

        maxPrice = Math.Max(amountOfRubles, amountOfDollars);

        if (maxPrice < amountOfEuro)
        {
            maxPrice = amountOfEuro;
        }
        if (maxPrice < amountOfB)
        {
            maxPrice = amountOfB;
        }
        if (maxPrice < amountOfM)
        {
            maxPrice = amountOfM;
        }
               

        Console.WriteLine("{0:f2}", Math.Ceiling(maxPrice));
    }
}
