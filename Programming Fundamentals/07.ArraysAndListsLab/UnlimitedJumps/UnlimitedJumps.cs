using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnlimitedJumps
{
    class UnlimitedJumps
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int jump = int.Parse(Console.ReadLine());

            var solution = jump % n;

            Console.WriteLine(solution);
        }
    }
}
