using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayContainsElement
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var numberToFind = int.Parse(Console.ReadLine());
        bool contain = false;

        for (int i = 0; i < numbers.Length-1; i++)
        {
            if (numbers[i] == numberToFind)
            {
                contain = true;
                Console.WriteLine("yes");
                break;
            }
        }

        if (!contain)
        {
            Console.WriteLine("no");
        }
    }
}

