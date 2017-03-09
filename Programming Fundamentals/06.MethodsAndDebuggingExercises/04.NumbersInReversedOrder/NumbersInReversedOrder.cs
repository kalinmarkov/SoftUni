using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            PrintInReversedOrder(str);

        }

        public static void PrintInReversedOrder(string str)
        {
            for (var i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
