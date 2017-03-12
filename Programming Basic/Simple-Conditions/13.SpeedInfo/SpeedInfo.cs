﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SpeedInfo
{
    class SpeedInfo
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (10 >= speed || speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (50 < speed && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (150 > speed || speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}