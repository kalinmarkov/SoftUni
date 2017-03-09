using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var step = int.Parse(Console.ReadLine());
            var found = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = elements.Length - 1; j > i; j--)
                {
                    if (elements[i] - elements[j] == step || elements[j] - elements[i] == step)
                    {
                        found++;
                    }
                }
            }

            Console.WriteLine(found);
        }
    }
}
