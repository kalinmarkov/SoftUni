using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int sumOfDigits = 0;
            int number = i;
            while (number > 0)
            {
                sumOfDigits += number % 10;
                number = number / 10;
            }
            bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
            Console.WriteLine("{0} -> {1}", i, isSpecial);
        }

        //int n = int.Parse(Console.ReadLine());
        //int sum = 0;

        //for (int i = 1; i <= n; i++)
        //{
        //    if (i < 10)
        //    {
        //        if (i % 5 == 0)
        //        {
        //            Console.WriteLine(i + "-> True");
        //        }
        //        else if (i % 7 == 0)
        //        {
        //            Console.WriteLine(i + "-> True");
        //        }
        //        else if (i % 11 == 0)
        //        {
        //            Console.WriteLine(i + "-> True");
        //        }
        //        else
        //        {
        //            Console.WriteLine(i + "-> False");
        //        }

        //    }
        //    else 
        //    {
        //        int firstDigit = i % 10;
        //        int secondDigit = i / 10;
        //        sum += firstDigit + secondDigit;
        //        if (sum >= 10)
        //        {
        //            firstDigit = sum % 10;
        //            secondDigit = sum / 10;
        //            sum += firstDigit + secondDigit;
        //            sum = sum / 10;
        //        }

        //        if (sum % 5 == 0)
        //        {
        //            Console.WriteLine(i + "-> True");
        //        }
        //        else if (sum % 7 == 0)
        //        {
        //            Console.WriteLine(i + "-> True");
        //        }
        //        else if (sum % 11 == 0)
        //        {
        //            Console.WriteLine(i + "-> True");
        //        }
        //        else
        //        {
        //            Console.WriteLine(i + "-> False");
        //        }
        //    }

        //    sum = 0;

        //}
    }
}

