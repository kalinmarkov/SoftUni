using System;

namespace _03.PrintingTriangle
{
    public class PrintingTriangle
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintingTriangleOfNumbers(n);
        }

        public static void PrintingTriangleOfNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
