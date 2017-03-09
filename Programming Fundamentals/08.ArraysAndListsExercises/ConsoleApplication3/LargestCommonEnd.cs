using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int minLenght = Math.Min(firstArray.Length, secondArray.Length);

            int leftCounter = CheckEqualArrays(firstArray, secondArray, minLenght);

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            int rightCounter = CheckEqualArrays(firstArray, secondArray, minLenght);

            Console.WriteLine(Math.Max(leftCounter, rightCounter));
        }

        private static int CheckEqualArrays(string[] str1, string[] str2, int minLenght)
        {
            int counter = 0;
            for (int i = 0; i < minLenght; i++)
            {
                if (str1[i] == str2[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }
    }
}
