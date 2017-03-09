using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            int[] sum = new int[nums.Length];

            for (int i = 0; i < rotation; i++)
            {
                int lastElement = nums[nums.Length - 1];

                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = lastElement;

                for (int j = 0; j < nums.Length; j++)
                {
                    sum[j] += nums[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
