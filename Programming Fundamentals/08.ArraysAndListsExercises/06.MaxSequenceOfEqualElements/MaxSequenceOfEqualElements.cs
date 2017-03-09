using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 1;
            int lenght = 0;
            int index = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                if (count > lenght)
                {
                    lenght = count;
                    index = numbers[i];
                }
                if (numbers[i] != numbers[i + 1])
                {
                    count = 1;
                }
            }
            int[] output = new int[lenght];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = index;
                Console.Write(string.Join(" ", output[i] + " "));
            }
        }
    }
}
