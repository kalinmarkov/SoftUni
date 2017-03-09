using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.V2.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentSum = 0;
            int previousSum = 0;
            int maxDiff = 0;
            int currentDiff = 0;

            for (int i = 1; i <= n; i++) 
            {
                previousSum = currentSum;
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                currentSum = num1 + num2;
                currentDiff = Math.Abs(currentSum - previousSum);
                if (currentDiff > maxDiff && i >= 2)
                {
                    maxDiff = currentDiff;
                }
            }
            if (maxDiff == 0)
            {
                Console.WriteLine("Yes value " + currentSum);
            }
            else
            {
                Console.WriteLine("no maxdiff " + maxDiff);
            }
        }
    }
}
