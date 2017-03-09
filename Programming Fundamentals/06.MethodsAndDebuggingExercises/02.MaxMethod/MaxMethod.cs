using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class MaxMethod
    {
        public static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMaxNumber(num1, num2, num3));
        }

        public static int GetMaxNumber(int num1, int num2, int num3)
        {
            int maxNum = num1;

            if (maxNum < num2)
            {
                maxNum = num2;
            }

            if (maxNum < num3)
            {
                maxNum = num3;
            }

            return maxNum;
        }
    }
}
