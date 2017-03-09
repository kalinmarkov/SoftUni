using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RemoveNegativesAndReverse
{
    class RemoveNegativeAndReverse
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var newNums = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    newNums.Add(numbers[i]);
                }
            }

            newNums.Reverse();

            if (newNums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", newNums));
            }

        }
    }
}
