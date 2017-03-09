using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class HornetWings
{
    static void Main()
    {
        var wingFlaps = ulong.Parse(Console.ReadLine());
        var distanceFor1000wingFlaps = decimal.Parse(Console.ReadLine());
        var endurance = BigInteger.Parse(Console.ReadLine());

        var distance = (wingFlaps / 1000m) * distanceFor1000wingFlaps;
        var hornetFlapsTime = wingFlaps / 100;
        var hornetRest = (wingFlaps / endurance) * 5;
        var totalTime = (hornetFlapsTime + hornetRest);

        Console.WriteLine($"{distance:F2} m.");
        Console.WriteLine($"{totalTime} s.");
        

    }
}

