using System;

class TransportPrice
{
    static void Main()
    {
        int km = int.Parse(Console.ReadLine());
        string day = Console.ReadLine().ToLower();
        double taxiDay = 0.79;
        double taxiNight = 0.90;
        double bus = 0.09;
        double train = 0.06;
        double taxiPrice = 0.70;
        double busPrice = 0.0;
        double trainPrice = 0.0;
        double tripPrice = 0.0;

        if (km < 20)
        {
            if (day == "day") taxiPrice += km * taxiDay;
            if (day == "night") taxiPrice += km * taxiNight;

            Console.WriteLine(taxiPrice);            
        }

        if (km >= 20 && km < 100)
        {
            if (day == "day") taxiPrice += km * taxiDay;
            if (day == "night") taxiPrice += km * taxiNight;
            if (day == "day" || day == "night") busPrice += km * bus;

            tripPrice = Math.Min(taxiPrice, busPrice);

            Console.WriteLine(tripPrice);
        }

        if (km >= 100)
        {
            if (day == "day") taxiPrice += km * taxiDay;
            if (day == "night") taxiPrice += km * taxiNight;
            if (day == "day" || day == "night") busPrice += km * bus;
            if (day == "day" || day == "night") trainPrice += km * train;

            tripPrice = Math.Min(taxiPrice, busPrice);
            if (tripPrice > trainPrice)
            {
                tripPrice = trainPrice;
                Console.WriteLine(tripPrice);
            }
            else
            {
                Console.WriteLine(tripPrice);
            }
        }
    }
}

