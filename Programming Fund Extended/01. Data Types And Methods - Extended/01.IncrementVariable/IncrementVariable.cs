using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Increment_Variable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            byte variable = 0;  // MAX VALUE = 255
            int times = 0;

            for (int i = 0; i < n; i++)
            {
                variable++;

                if (variable == 0)
                {
                    times++;
                }
            }

            Console.WriteLine(variable);
            Console.WriteLine($"Overflowed {times} times");
        }
    }
}
