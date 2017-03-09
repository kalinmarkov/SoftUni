using System;

namespace _02.SignOfIntegerNumber
{
    public class SignOfIntegerNumber
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }

        public static void PrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The number {0} is positive.", num);
            }
            else if (num < 0)
            {
                Console.WriteLine("The number {0} is negative.", num);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", num);
            }
        }
    }
}
