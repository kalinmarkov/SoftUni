using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<int> nums = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                nums.Add(int.Parse(input[i]));
            }
            nums.Sort();

            var pos = 0;
            while (pos < nums.Count)
            {
                int num = nums[pos], count = 1;
                while (pos + count < nums.Count &&
                       nums[pos + count] == num)
                {
                    count++;
                }
                pos = pos + count;
                Console.WriteLine($"{num} -> {count}");
            }

        }        
    }
}
