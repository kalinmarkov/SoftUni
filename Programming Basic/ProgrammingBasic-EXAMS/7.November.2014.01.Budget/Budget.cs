using System;

class Budget
{
    static void Main()
    {
        int amount = int.Parse(Console.ReadLine());
        int daysForGoingOut = int.Parse(Console.ReadLine());
        int weekendsInHome = int.Parse(Console.ReadLine());
        double days = (22 - daysForGoingOut) * 10 + (daysForGoingOut * Math.Floor(amount * 0.03 + 10));
        double weekends = (4 * 2 - (weekendsInHome * 2)) * 20;
        double totalMoney = amount - days - weekends - 150;
        if (totalMoney > 0)
        {
            Console.WriteLine("Yes, leftover {0}.", Math.Round(totalMoney));
        }
        else if (totalMoney == 0)
        {
            Console.WriteLine("Exact Budget.");
        }
        else if (totalMoney < 0)
        {
            Console.WriteLine("No, not enough {0}.", Math.Abs(totalMoney));
        }
    }
}

