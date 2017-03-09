using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PersonalTitle
{
    class PersonalTitle
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gander = Console.ReadLine().ToString().ToLower();

            if (age < 16)
            {
                if (gander == "m") Console.WriteLine("Master");
                else if (gander == "f") Console.WriteLine("Miss");
            }
            else
            {
                if (gander == "m") Console.WriteLine("Mr.");
                else if (gander == "f") Console.WriteLine("Ms.");
            }
        }
    }
}
