﻿using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxSumAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            var input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }

        Console.WriteLine("Sum = " + numbers.Sum());
        Console.WriteLine("Min = " + numbers.Min());
        Console.WriteLine("Max = " + numbers.Max());
        Console.WriteLine("Average = " + numbers.Average());
    }
}

