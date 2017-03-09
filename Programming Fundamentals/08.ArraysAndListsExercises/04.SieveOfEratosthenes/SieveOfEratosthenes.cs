using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintPrimeNumbers(n);
        }

        static void PrintPrimeNumbers(int n)
        {
            bool[] primes = new bool[n + 1];

            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    Console.WriteLine(i);

                    for (int j = 2; j <= n; j++)
                    {
                        if (j*i >= 0 && j*i <= n)
                        {
                            primes[j * i] = false;
                        }
                    }
                }
            }
        }      
    }
}
