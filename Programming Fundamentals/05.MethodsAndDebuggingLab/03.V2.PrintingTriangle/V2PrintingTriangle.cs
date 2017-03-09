using System;

namespace _03.V2.PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        public static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
}
