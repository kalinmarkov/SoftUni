using System;

class Harvest
{
    static void Main()
    {
        int Area = int.Parse(Console.ReadLine());
        double grapesKilos = double.Parse(Console.ReadLine());
        int neededWine = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        double literWine = 0.4 * Area * grapesKilos / 2.5;

        if (literWine >= neededWine)
        {
            Console.WriteLine("Good harvest this year! Total wine: {0} liters. ", Math.Floor(literWine));
            Console.WriteLine("{0} liters left -> {1} liters per person.",
                Math.Ceiling((literWine - neededWine)), Math.Ceiling(((literWine - neededWine) / workers)));
        }
        else
        {
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                Math.Floor(neededWine - literWine));
        }
    }
}

