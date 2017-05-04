using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumOfTwoNumbers
{
    static void Main()
    {
        var step = int.Parse(Console.ReadLine());
        var endNumber = int.Parse(Console.ReadLine());
        var magicNumber = int.Parse(Console.ReadLine());

        var count = 1;
        var hasntCombination = true;

        for (int i = 1; i <= endNumber; i += step)
        {
            for (int j = 1; j <= endNumber; j += step)
            {
                if (i + j == magicNumber)
                {
                    hasntCombination = false;
                    Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNumber})");
                }
                count++;
            }
        }

        if (hasntCombination)
        {
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}

