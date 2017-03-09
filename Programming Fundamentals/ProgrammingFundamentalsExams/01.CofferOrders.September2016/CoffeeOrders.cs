using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CoffeeOrders
{

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        decimal totalPrice = 0;

        for (int i = 0; i < num; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            long capsulesCount = long.Parse(Console.ReadLine());

            decimal currentPrice = DateTime.DaysInMonth(date.Year, date.Month) * capsulesCount * pricePerCapsule;
            totalPrice += currentPrice;

            Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
        }

        Console.WriteLine($"Total: ${totalPrice:F2}");
    }
}

