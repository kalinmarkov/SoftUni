using System;
using System.Linq;

namespace _09.ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] result = ExtractMiddleElement(nums);

            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] ExtractMiddleElement(int[] nums)
        {
            int lenght = nums.Length;
            if (lenght == 1)
            {
                return nums;
            }
            else if (lenght % 2 == 0)
            {
                return new int[] { nums[lenght / 2 - 1], nums[lenght / 2] };
            }
            else
            {
                return new int[] { nums[lenght / 2 - 1], nums[lenght / 2], nums[lenght / 2 + 1] };
            }

        }

    }
}
