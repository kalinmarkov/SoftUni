using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26March._02.PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            double water = (P1 * H) + (P2 * H);
          

            if (V >= water)
            {
                
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", 
                                   Math.Truncate((water / V) * 100),
                                   Math.Truncate(P1 * H / water * 100),
                                   Math.Truncate(P2 * H / water * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                                   (H),
                                   (water - V));
            }
        }
    }
}
