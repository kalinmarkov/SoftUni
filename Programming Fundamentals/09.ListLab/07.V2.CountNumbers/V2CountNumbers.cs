using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.V2.CountNumbers
{
    class V2CountNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            nums.Sort();

            var start = 0;
            var len = 1;

            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums.Count - 1 || nums[i] != nums[i + 1])
                {
                    Console.WriteLine(nums[start] + " -> " + len);
                    start = i + 1;
                    len = 1;
                }
                else
                {
                    
                    len++;
                }
            }
        }
    }
}
