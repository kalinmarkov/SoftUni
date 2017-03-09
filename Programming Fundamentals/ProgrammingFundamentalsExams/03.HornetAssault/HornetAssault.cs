using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class HornetAssault
{
    static void Main(string[] args)
    {
        var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
        var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
        var hornetsPower = hornets.Sum();
        var beeLeft = new List<long>();
        var count = hornets.Count;
        var counter = 0;
        for (int i = 0; i < beehives.Count; i++)
        {
            if (beehives.Count == 0 || hornets.Count == 0)
            {
                break;
            }
            if (hornetsPower > beehives[i])
            {
                beehives.RemoveAt(i);
            }
            else if (hornetsPower >= beehives[i])
            {
                beehives.RemoveAt(i);
                hornets.RemoveAt(i);
                hornetsPower = hornets.Sum();

            }
            else if (hornetsPower < beehives[i])
            {
                counter++;
                hornets.RemoveAt(i);
                beehives[i] = beehives[i] - hornetsPower;
                hornetsPower = hornets.Sum();
                beeLeft.Add(beehives[i]);
            }

            i--;
        }

        if (counter > 0)
        {
            Console.WriteLine(string.Join(" ", beeLeft));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets));

        }
    }
}
