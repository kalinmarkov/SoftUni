using System;
using System.Numerics;

namespace _13.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fact = 1;

            for (int i = n; i > 1; i--)
            {
                fact = BigInteger.Multiply(i, fact);
            }

            Console.WriteLine(fact);
        }
    }
}
