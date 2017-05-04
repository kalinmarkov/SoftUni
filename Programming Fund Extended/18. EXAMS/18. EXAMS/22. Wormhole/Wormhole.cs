using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Wormhole
{
    static void Main()
    {
        var input = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var steps = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != 0)
            {
                var currentIndex = input[i];
                input[i] = 0;
                i = currentIndex;
            }

            steps++;
        }

        Console.WriteLine(steps);
    }

}

