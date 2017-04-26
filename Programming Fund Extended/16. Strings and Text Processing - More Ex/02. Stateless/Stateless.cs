using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Stateless
{
    static void Main()
    {
        // 60/100
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "collapse")
            {
                break;
            }

            var pattern = Console.ReadLine();
            var symbol = string.Empty;

            for (int i = 0; i < pattern.Length - 1; i++)
            {
                input = input.Replace(pattern, string.Empty).Trim();
                for (int j = 0; j < input.Length; j++)
                {
                    if (pattern[i] == input[j])
                    {
                        symbol = pattern[i].ToString();
                        input = input.Replace(symbol, string.Empty).Trim();
                    }

                }

            }

            if (input.Length == 0)
            {
                Console.WriteLine("(void)");
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}

