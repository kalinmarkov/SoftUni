using System;

namespace _18.Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int numberCount = int.Parse(Console.ReadLine());

            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;
                    if (i + numberCount < text.Length)
                    {
                        Console.WriteLine(text.Substring(i, numberCount + 1));
                    }
                    else
                    {
                        Console.WriteLine(text.Substring(i));
                    }
                    i += numberCount;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
