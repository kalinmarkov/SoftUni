using System;

class Flowers
{
    static void Main()
    {
        int numberOfChrysanthemums = int.Parse(Console.ReadLine());
        int numberOfRoses = int.Parse(Console.ReadLine());
        int numberOfTulips = int.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();
        char holiday = char.Parse(Console.ReadLine());
        double price = 0.0;

        if (season == "spring" || season == "summer")
        {
            price = numberOfChrysanthemums * 2.0 + numberOfRoses * 4.1 + numberOfTulips * 2.5;

            if (holiday == 'Y')
            {
                price += price * 0.15;
            }

            if (numberOfTulips > 7 && season == "spring")
            {
                price -= price * 0.05;
            }

        }
        else if (season == "autumn" || season == "winter")
        {
            price = numberOfChrysanthemums * 3.75 + numberOfRoses * 4.5 + numberOfTulips * 4.15;

            if (holiday == 'Y')
            {
                price += price * 0.15;
            }

            if (numberOfRoses >= 10 && season == "winter")
            {
                price -= price * 0.10;
            }
        }

        if (numberOfChrysanthemums + numberOfRoses + numberOfTulips > 20)
        {
            price -= price * 0.20;
        }

        price += 2;
        Console.WriteLine("{0:f2}", price);
    }
}

