using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DistinctList
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        Console.WriteLine(string.Join(" ", nums.Distinct()));
    }
}

