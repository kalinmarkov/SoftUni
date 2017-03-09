using System;

namespace _06.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            PrintIsNumberPrime(number);
        }

        public static void PrintIsNumberPrime (long number)
        {
            bool isPrime = true;

            if (number < 2)
            {
                Console.WriteLine("False");
                return;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }

            }

            if (isPrime)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
