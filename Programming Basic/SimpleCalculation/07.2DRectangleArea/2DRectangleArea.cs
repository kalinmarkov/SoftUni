using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = decimal.Parse(Console.ReadLine());
            var y1 = decimal.Parse(Console.ReadLine());
            var x2 = decimal.Parse(Console.ReadLine());
            var y2 = decimal.Parse(Console.ReadLine());
            var x = Math.Abs(x2 - x1);
            var y = Math.Abs(y2 - y1);
            var area = x * y;
            var perimeter = 2 * (x + y);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
