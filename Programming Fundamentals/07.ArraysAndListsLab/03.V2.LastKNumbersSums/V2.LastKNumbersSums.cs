using System;
using System.Linq;

namespace _03.V2.LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] arr = new long[n];
            arr[0] = 1;

            for (int current = 1; current < arr.Length; current++)
            {
                int start = Math.Max(0, current - k);
                int end = current - 1;
                long sum = 0;

                for (int previous = start; previous <= end; previous++)
                {
                    sum += arr[previous];
                }
                arr[current] = sum;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
