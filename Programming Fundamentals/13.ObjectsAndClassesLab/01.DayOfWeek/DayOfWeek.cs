using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var dateStr = Console.ReadLine();
            var tokens = dateStr.Split('-').Select(int.Parse).ToArray();
            var date = new DateTime(tokens[2], tokens[1], tokens[0]);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
