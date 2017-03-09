using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int len = Math.Min(firstArray.Length, secondArray.Length);

            int firstCounter = 0;
            int secondCounter = 0;
            int counter = 0;

            for (int i = 0; i < len; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }
                else 
                {
                    if (firstArray[i] < secondArray[i])
                    {
                        firstCounter++;
                    }
                    else
                    {
                        secondCounter++;
                    }
                    
                }
            }

            if (counter == len)
            {
                if (firstArray.Length <= secondArray.Length)
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                }
                else if (firstArray.Length > secondArray.Length)
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                }

            }
            else if (firstCounter > secondCounter)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else if (firstCounter < secondCounter)
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
        }

    }
}
