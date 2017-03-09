using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SweetDessert
{
    static void Main()
    {
        var money = decimal.Parse(Console.ReadLine());
        var guests = int.Parse(Console.ReadLine());
        var bananaPrice = decimal.Parse(Console.ReadLine());
        var eggPrice = decimal.Parse(Console.ReadLine());
        var berryPrice = decimal.Parse(Console.ReadLine());

        var portions = guests / 6;
        if (guests % 6 != 0)
        {
            portions++;
        }

        var pricePerPortion = 2 * bananaPrice + 4 * eggPrice + 0.2m * berryPrice;
        var totalPrice = pricePerPortion * portions;

        if (money < totalPrice)
        {
            var shortage = totalPrice - money;
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", shortage);
        }
        else
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", totalPrice);
        }
    }
}

