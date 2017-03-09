using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.VowelSum
{
    class VowelSum
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            int vowelSum = 0;

            for (int i = 0; i < str.Length; i ++)
            {
                char currentSymbol = str[i];
                switch (currentSymbol)
                {
                    case 'a':
                        vowelSum += 1;
                        break;
                    case 'e':
                        vowelSum += 2;
                        break;
                    case 'i':
                        vowelSum += 3;
                        break;
                    case 'o':
                        vowelSum += 4;
                        break;
                    case 'u':
                        vowelSum += 5;
                        break;
                }
            }
            Console.WriteLine(vowelSum);
        }
    }
}
