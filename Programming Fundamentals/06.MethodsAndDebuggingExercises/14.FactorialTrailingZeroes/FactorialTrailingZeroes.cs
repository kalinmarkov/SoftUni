using System;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger fact = 1;
            BigInteger temporaryNum = 0;
            int counter = 0;

            for (int i = num; i > 1; i--)
            {
                fact = BigInteger.Multiply(i, fact);
            }

            while (temporaryNum == 0)
            {
                temporaryNum = fact % 10;

                if (temporaryNum % 10 == 0)
                {
                counter++;
                }

                fact = fact / 10;
            }
            Console.WriteLine(counter);
        }
    }
}
