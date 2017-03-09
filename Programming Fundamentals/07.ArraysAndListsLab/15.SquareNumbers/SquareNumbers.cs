using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            List<int> squares = new List<int>();

            foreach (var num in numbers)
            {
                double sqrt = Math.Sqrt(num);
                if (sqrt == (int)sqrt)
                {
                    squares.Add(num);
                }
            }
            squares.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
