using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] middleElements = new int[2 * k];

            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] = numbers[k + i]; 
            }

            int[] firstKElements = new int[k];

            for (int i = 0; i < firstKElements.Length; i++)
            {
                firstKElements[i] = numbers[i];
            }

            int[] lastKElements = new int[k];

            for (int i = 0; i < lastKElements.Length; i++)
            {
                lastKElements[i] = numbers[i + 3 * k];
            }

            Array.Reverse(firstKElements);
            Array.Reverse(lastKElements);

            int[] firstAndLastKElements = new int[2 * k];

            for (int i = 0; i < firstAndLastKElements.Length; i++)
            {
                if (i < k)
                {
                    firstAndLastKElements[i] = firstKElements[i];
                }
                else
                {
                    firstAndLastKElements[i] = lastKElements[i - k];
                }
            }

            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] += firstAndLastKElements[i];
            }

            Console.WriteLine(string.Join(" ", middleElements));
        }
    }
}
