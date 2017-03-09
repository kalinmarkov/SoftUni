using System;

namespace _14.IntegerToHexAndBinary
{
    public class IntegerToHexAndBinary
    {
        public static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            string hexadecimal = Convert.ToString(value, 16).ToUpper();
            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);

        }
    }
}
