using System;

namespace _07.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMaxNumber(first, second));
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());

                Console.WriteLine((char)GetMaxChar(first,second));
            }
            else if (input == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                Console.WriteLine(GetMaxString(first, second));
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }

        }

        public static int GetMaxNumber(int first, int second)
        {
            int max = Math.Max(first, second);
            return max;
        }
        
        public static int GetMaxChar (int first, int second)
        {
            int max = Math.Max(first, second);
            return max;
        }

        public static string GetMaxString (string first, string second)
        {
            string max = "";
            if (first.CompareTo(second) >= 0)
            {
                max = first;
            }
            else
            {
                max = second;
            }

            return max;
        }
    }
}
