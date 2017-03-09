using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            var addMin = min + 15;
            var totalMin = addMin % 60;

            if (addMin >= 60)
            {
                hour++;
            }
            if (hour == 24)
            {
                hour = 0;
            }
            if (addMin > 9)
            {
                Console.WriteLine("{0:0}:{1:00}", hour, totalMin);
            }
            if (addMin <= 9)
            {
                Console.WriteLine("{0:0}:{1:00}", hour, totalMin);
            }
        }
    }
}
