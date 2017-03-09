using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ClassRoom
{
    class ClassRoom
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            if (2 <= h && h <= w && w <= 100)
            {
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        if ((i == 0) || (j == 0) || (i == h - 1) || (j == h - 1))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("The number is out of range. It have to be between 2 and 100");
            }
        }
    }
}
