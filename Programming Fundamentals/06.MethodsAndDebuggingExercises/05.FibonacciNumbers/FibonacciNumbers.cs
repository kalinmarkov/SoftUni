using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacciNumber(number));
        }

        public static int GetFibonacciNumber(int number)
        {
            int fibFirstNum = 1;
            int ficSecondNum = 1;
            int fibNextNum = 0;

            for (int i = 0; i < number - 1; i++)
            {
                fibNextNum = fibFirstNum + ficSecondNum;
                fibFirstNum = ficSecondNum;
                ficSecondNum = fibNextNum;
            }

            return ficSecondNum;
        }
    }
}
