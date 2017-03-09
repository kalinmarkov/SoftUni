using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            var centimeters = double.Parse(Console.ReadLine());
            var inches = centimeters * 2.54;
            Console.WriteLine(inches);
        }
    }
}
