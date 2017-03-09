using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFromStars
{
    class SquareFromStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (2 <= n && n <= 100)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((i == 0) || (j == 0) || (i == n - 1) || (j == n - 1))
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
