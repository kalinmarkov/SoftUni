﻿using System;
using System.Linq;

namespace _04.TrippleSum
{
    class TrippleSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            for (int a = 0; a < arr.Length - 1; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    int sum = arr[a] + arr[b];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr[a]} + {arr[b]} == {sum}");
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
