using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CamelsBack
{
    static void Main()
    {
        var buildings = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var camelsBack = int.Parse(Console.ReadLine());

        if (camelsBack == buildings.Count)
        {
            Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
        }
        else if (camelsBack < buildings.Count)
        {
            var count = 0;

            while (camelsBack < buildings.Count)
            {
                buildings.RemoveAt(0);
                buildings.RemoveAt(buildings.Count - 1);
                count++;
            }

            Console.WriteLine($"{count} rounds");
            Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
        }
    }
}

