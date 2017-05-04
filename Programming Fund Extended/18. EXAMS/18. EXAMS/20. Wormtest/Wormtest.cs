using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Wormtest
{
    static void Main()
    {
        var wormLength = ulong.Parse(Console.ReadLine()) * 100;
        var wormWidth = double.Parse(Console.ReadLine());

        var remainder = wormLength % wormWidth;

        if (wormWidth == 0)
        {
            remainder = 0;
        }

        if (remainder == 0)
        {
            Console.WriteLine($"{wormLength * wormWidth:F2}");
        }
        else if (remainder != 0)
        {
            var percentage = wormLength / wormWidth * 100;
            Console.WriteLine($"{percentage:F2}%");
        }
    }
}

