using System;

namespace _08.MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultiplyOfEvenAndOdd(num));

        }

        public static int GetMultiplyOfEvenAndOdd(int num)
        {
            int lastDigit = 0;
            int evenSum = 0;
            int oddSum = 0;

            do
            {
                lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                else
                {
                    oddSum += lastDigit;
                }
                num = num / 10;

            } while (num != 0);

            int result = evenSum * oddSum;
            return result;
            
        }
    }
}
