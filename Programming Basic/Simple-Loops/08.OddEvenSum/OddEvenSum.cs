using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum1 += num;
                }
                else
                {
                    sum2 += num;
                }
            }

            if (sum1 == sum2)   
            {
                Console.WriteLine("Yes \n Sum = " + sum1);
            }
            else
            {
                Console.WriteLine("No \n Diff = " + Math.Abs(sum1 - sum2));
            }
        }
    }
}
