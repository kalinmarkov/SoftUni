using System;

namespace _04.DrawAFilledSquare
{
    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintBottomOfSquare(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleOfSquare(n);
            }
            PrintBottomOfSquare(n);
        }

        public static void PrintBottomOfSquare(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        public static void PrintMiddleOfSquare(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }
    }
}
