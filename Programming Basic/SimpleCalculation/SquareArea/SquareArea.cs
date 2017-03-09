using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            

            try
            {
                var a = float.Parse(Console.ReadLine());
                var area = a * a;
                Console.WriteLine(area);
            }
            catch (Exception)
            {
                Console.WriteLine("error");
                throw;
            }

        }
    }
}
