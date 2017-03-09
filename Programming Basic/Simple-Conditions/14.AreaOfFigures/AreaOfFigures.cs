using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            

            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var area = Math.Round((a * a), 3);
                Console.WriteLine(area);
            }
            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var area = Math.Round((a * b), 3);
                Console.WriteLine(area);
            }
            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var area = Math.Round((Math.PI * r * r), 3);
                Console.WriteLine(area);
            }
            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var area = Math.Round((a * h / 2), 3);
                Console.WriteLine(area);
            }


        }
    }
}
