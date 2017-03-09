using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegerInsertion
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var number = int.Parse(input);
            var index = number;

            while (index >= 10)
            {
                index /= 10;
            }

            nums.Insert(index, number);
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}

