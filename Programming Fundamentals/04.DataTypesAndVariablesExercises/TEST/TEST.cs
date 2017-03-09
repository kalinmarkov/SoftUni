using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class TEST
    {
        static void Main(string[] args)
        {
            char[] array = new char[3];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = char.Parse(Console.ReadLine());
            }

            array = array.Reverse().ToArray();

            Console.WriteLine(string.Join("", array));
        }
    }
}
