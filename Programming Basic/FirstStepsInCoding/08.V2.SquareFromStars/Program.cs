using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.V2.SquareFromStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string topBottom = new string('*', n);

            Console.WriteLine(topBottom);

            for (int i = 0; i < n - 2; i++)
            {
                string whiteSpaces = new string(' ', n - 2);
                Console.WriteLine('*' + whiteSpaces + '*');
            }
            Console.WriteLine(topBottom);
        }
    }
}
