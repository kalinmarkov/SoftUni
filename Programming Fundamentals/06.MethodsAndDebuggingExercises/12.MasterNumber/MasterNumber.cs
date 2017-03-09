using System;
using System.Linq;

namespace _12.MasterNumber
{
    class MasterNumber
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (IsPalindrome(i) && ContainEvenDigit(i) && SumOfDigitsDevidedBySeven(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int num)
        {
            int currNum = num;
            int temporaryNum = 0;
            int reversedNum = 0;
            while (num > 0)
            {
                temporaryNum = num % 10;
                reversedNum = reversedNum * 10 + temporaryNum;
                num = num / 10;
            }
            if (currNum == reversedNum)
            {
                return true;
            }
            return false;

        }

        static bool SumOfDigitsDevidedBySeven(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool ContainEvenDigit(int num)
        {
            int lastDigit = 0;

            while (num > 0)
            {
                lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
                num = num / 10;
            }

            return false;

        }
    }
}
