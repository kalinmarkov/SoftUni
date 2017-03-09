using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse);
            var sorted = nums.OrderByDescending(x => x);
            var biggest3 = sorted.Take(3);
            Console.WriteLine(string.Join(" ", biggest3));
        }
    }
}
