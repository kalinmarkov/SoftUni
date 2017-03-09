using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());

            var sum = time1 + time2 + time3;
            var minutes = sum / 60;
            var seconds = sum % 60;

            var stringAsSeconds = seconds.ToString();

            if (seconds < 10)
            {
                stringAsSeconds = 0 + seconds.ToString();
            }
            Console.WriteLine("{0}:{1}", minutes, stringAsSeconds);
        }
    }
}
