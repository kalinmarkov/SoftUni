using System;

class MatchTickets
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());
        double transport = 0.0;
        double totalMoney = 0.0;

        if (people <= 4) transport = budget * 0.75;
        if (5 <= people && people <= 9) transport = budget * 0.6;
        if (10 <= people && people <= 24) transport = budget * 0.5;
        if (25 <= people && people <= 49) transport = budget * 0.4;
        if (people >= 50) transport = budget * 0.25;

        if (category == "VIP")
        {
            totalMoney = budget - transport - 499.99 * people;
            if (totalMoney >= 0)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", totalMoney);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(totalMoney));
            }
        }

        if (category == "Normal")
        {
            totalMoney = budget - transport - 249.99 * people;
            if (totalMoney >= 0)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", totalMoney);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(totalMoney));
            }
        }
    }
}

