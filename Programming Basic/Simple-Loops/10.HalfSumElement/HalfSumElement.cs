using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                Math.Abs(sum += num);
            }


            if ((sum - max) == max)
            {
                Console.WriteLine("Yes \nSum = {0}", max);
            }
            else
            {
                int diff = Math.Abs(max - (sum - max));
                Console.WriteLine("No \nDiff = {0}", diff);
            }
        }
    }
}
