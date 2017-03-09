using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEMO
{
    class DemoArrays
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var reversed = new List<string>();
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                reversed.Add(nums[i]).Sp;
            }
            
            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
