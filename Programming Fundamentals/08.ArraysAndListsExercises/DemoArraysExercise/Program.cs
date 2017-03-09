using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());

        var sum = new int[arr.Length];

        for (int i = 0; i < k; i++)
        {
            var last = arr[arr.Length - i - 1];

            for (int j = arr.Length - 1; j > 0; j--)
            {
                arr[j] = arr[j - 1];
            }

            arr[0] = last;

            for (int j = 0; j < arr.Length; j++)
            {
                sum[j] += arr[j];
            }

        }

        Console.WriteLine(string.Join(" ", sum));
    }
}

