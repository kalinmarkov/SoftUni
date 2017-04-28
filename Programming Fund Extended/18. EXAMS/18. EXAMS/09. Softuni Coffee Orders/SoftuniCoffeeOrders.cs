using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SoftuniCoffeeOrders
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var totalPrice = 0M;

        for (int i = 0; i < n; i++)
        {
            var pricePerCapsule = decimal.Parse(Console.ReadLine());
            var orderDay = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            var capsulesCount = long.Parse(Console.ReadLine());

            var daysInMonth = DateTime.DaysInMonth(orderDay.Year, orderDay.Month);
            var currentPrice = ((daysInMonth * capsulesCount) * pricePerCapsule);

            Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");

            totalPrice += currentPrice;
        }

        Console.WriteLine($"Total: ${totalPrice:F2}");
    }
}

