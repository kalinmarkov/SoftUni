using System;

namespace _15.FastPrimeChecker
{
    public class FastPrimeChecker
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 0; number <= n; number++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        //break;
                    }
                }
                if (number == 0 || number == 1)
                {
                    continue;
                }
                Console.WriteLine($"{number} -> {isPrime}");
            }

        }
    }
}
