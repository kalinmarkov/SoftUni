using System;

class Digits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstNum = n;

        int firstDigit = n / 100;
        int secondDigit = (n / 10) % 10;
        int thirdDigit = n % 10;
        int sumRow = firstDigit + secondDigit;
        int sumCol = firstDigit + thirdDigit;

        for (int i = 0; i < sumRow; i++)
        {
            for (int j = 0; j < sumCol; j++)
            {
                if (firstNum % 5 == 0)
                {
                    firstNum -= firstDigit;
                }
                else if (firstNum % 3 == 0)
                {
                    firstNum -= secondDigit;
                }
                else
                {
                Console.Write(firstNum + " ");
                }
            }
            Console.WriteLine();
        }


    }
}

