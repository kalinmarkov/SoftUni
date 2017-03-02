using System;

class OperationBetweenNumbers
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();
        double result = 0.0;

        if (num1 == 0 && (symbol == "/" || symbol == "%"))
        {
            Console.WriteLine("Cannot divide {0} by zero", num2);
            return;
        }

        if (num2 == 0 && (symbol == "/" || symbol == "%"))
        {
            Console.WriteLine("Cannot divide {0} by zero", num1);
            return;
        }

        if (symbol == "*")
        {
            result = num1 * num2;
            if (result % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", num1, symbol, num2, result);
            }
            else Console.WriteLine("{0} {1} {2} = {3} - odd", num1, symbol, num2, result);
        }
        else if (symbol == "+")
        {
            result = num1 + num2;
            if (result % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", num1, symbol, num2, result);
            }
            else Console.WriteLine("{0} {1} {2} = {3} - odd", num1, symbol, num2, result);
        }
        else if (symbol == "-")
        {
            result = num1 - num2;
            if (result % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", num1, symbol, num2, result);
            }
            else Console.WriteLine("{0} {1} {2} = {3} - odd", num1, symbol, num2, result);
        }
        else if (symbol == "/")
        {
            result = num1 / num2;
            Console.WriteLine("{0} {1} {2} = {3:f2}", num1, symbol, num2, result);
        }
        else if (symbol == "%")
        {
            result = num1 % num2;
            Console.WriteLine("{0} {1} {2} = {3}", num1, symbol, num2, result);
        }

    }
}

