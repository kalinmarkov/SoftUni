﻿using System;
using System.Numerics;

class BigFactorial
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}

