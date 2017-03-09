using System;
using System.Linq;

namespace ArrayPrimeNumber
{
    class ArrayPrimeNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] prime = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                prime[i] = true;
            }

            for (int i = 2; i < prime.Length; i++)
            {
                if (prime[i])
                {
                    for (int j = i + i; j < prime.Length; j += i)
                    {
                        if (prime[i])
                        {
                            prime[j] = false;
                        }
                    }
                }
            }

            for (int i = 0; i < prime.Length; i++)
            {
                if (prime[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
