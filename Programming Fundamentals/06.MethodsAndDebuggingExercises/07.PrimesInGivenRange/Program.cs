using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            GetPrime(startNum, endNum);
        }

        static void GetPrime(int startNum, int endNum)
        {
            if (startNum < 2)
            {
                startNum = 2;
            }
            bool firstPrime = true;
            for (int isPrime = startNum; isPrime <= endNum; isPrime++)
            {
                bool Prime = true;
                for (int numberInside = 2; numberInside <= Math.Sqrt(isPrime); numberInside++)
                {
                    if (isPrime % numberInside == 0)
                    {
                        Prime = false;
                        break;
                    }
                }

                if (Prime == true && firstPrime == true)
                {
                    Console.Write(isPrime);
                    firstPrime = false;
                }
                else if (Prime)
                {
                    Console.Write(", ");
                    Console.Write(isPrime);
                }
            }
            Console.WriteLine();
        }
    }
}
