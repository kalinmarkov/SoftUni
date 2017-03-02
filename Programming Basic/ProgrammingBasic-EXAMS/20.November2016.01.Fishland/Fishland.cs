using System;

class Fishland
{
    static void Main()
    {
        double skumriaPrice = double.Parse(Console.ReadLine());
        double cacaPrice = double.Parse(Console.ReadLine());
        double palamudKilos = double.Parse(Console.ReadLine());
        double safridKilos = double.Parse(Console.ReadLine());
        double shellKilos = int.Parse(Console.ReadLine());

        double palamudPrice = skumriaPrice + (0.6 * skumriaPrice);
        double safridPrice = cacaPrice + 0.8 * cacaPrice;
        double shellPrice = 7.5;

        double total = palamudPrice * palamudKilos +
                       safridPrice * safridKilos +
                       shellPrice * shellKilos;

        Console.WriteLine("{0:f2}", total);

    }
}

