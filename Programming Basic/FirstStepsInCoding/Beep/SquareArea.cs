using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beep
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please insert a value for side A: ");
                var a = (decimal.Parse(Console.ReadLine()));
                Console.Write("Please insert a value for side B: ");
                var b = (decimal.Parse(Console.ReadLine()));
                var area = Math.Abs(a * b);

                Console.WriteLine("Square Area is: " + area);
            }
            catch (Exception)
            {

                Console.WriteLine("Please enter a number");
            }

            
        }
    }
}
