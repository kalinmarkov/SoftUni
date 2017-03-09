using System;
using System.Numerics;

class BigFactorial
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine(factorial);
    }
}

