﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class LongerLine
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            GetLongerLineCloserToZero(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void GetLongerLineCloserToZero(double x1, double y1, 
            double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double c1 = Math.Abs(Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)));
            double c2 = Math.Abs(Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)));
            double c3 = Math.Abs(Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2)));
            double c4 = Math.Abs(Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2)));

            if ((c1 + c2) < (c3 + c4))
            {
                if (c3 > c4)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");                
                }

            }
            else if ((c1 + c2) > (c3 + c4))
            {
                if (c1 > c2)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }

            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }

        }
    }
}
