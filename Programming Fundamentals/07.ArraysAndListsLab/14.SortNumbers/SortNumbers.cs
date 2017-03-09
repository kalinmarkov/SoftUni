using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            string[] inputNums = Console.ReadLine().Split(' ');
            List<double> nums = new List<double>();

            foreach (var num in inputNums)
            {
                nums.Add(double.Parse(num));
            }

            nums.Sort();
            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
