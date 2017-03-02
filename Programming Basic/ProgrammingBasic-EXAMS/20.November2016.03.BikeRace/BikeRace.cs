using System;

class BikeRace
{
    static void Main()
    {
        int juniors = int.Parse(Console.ReadLine());
        int seniors = int.Parse(Console.ReadLine());
        string layout = Console.ReadLine().ToLower();

        double tax = 0.0;

        if (layout == "trail")
        {
            tax = juniors * 5.5 + seniors * 7;
            tax -= tax * 0.05;
        }
        else if (layout == "cross-country")
        {
            if (juniors + seniors >= 50)
            {
                tax = juniors * (8 - 8 * 0.25) + seniors * (9.5 - 9.5 * 0.25);
                tax -= tax * 0.05;
            }
            else
            {
                tax = juniors * 8 + seniors * 9.5;
                tax -= tax * 0.05;                    
            }
        }
        else if (layout == "downhill")
        {
            tax = juniors * 12.25 + seniors * 13.75;
            tax -= tax * 0.05;
        }
        else if (layout == "road")
        {
            tax = juniors * 20 + seniors * 21.5;
            tax -= tax * 0.05;
        }

        Console.WriteLine($"{tax:f2}");
    }
}

