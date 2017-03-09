using System;

namespace _03.Sum.Min.Max.First.Last.Average
{
    class SumMinMaxFirstLastAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int min = arr[0];
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                max = Math.Max(max, arr[i]);
            }

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("First = " + arr[0]);
            Console.WriteLine("Last = " + arr[arr.Length]);
            Console.WriteLine("Average = " + (double)sum / n);
        }
    }
}
