using System;

namespace _05.BooleanVariable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string booleanInput = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(booleanInput);

            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
