using System;

namespace _06.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double degree = double.Parse(Console.ReadLine());

            Console.WriteLine(GetMathPow(number, degree));
        }

        static double GetMathPow(double number, double degree)
        {
            double result = Math.Pow(number, degree);
            return result;
        }
    }
}
