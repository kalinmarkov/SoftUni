﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingByName
{
    class GreetingByName
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
            //Console.WriteLine($"Hello, {name}");
            //Console.WriteLine("Hello, " + name);
        
        }
    }
}
