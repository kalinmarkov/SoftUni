using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            PrintGreatings(name);
        }

        public static void PrintGreatings(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
