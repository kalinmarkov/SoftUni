using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            var randomCharacters = Console.ReadLine();
            var pattern = Console.ReadLine();

            var messages = new StringBuilder();

            if (pattern.Length == 0)
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(randomCharacters);
                return;
            }

            while (true)
            {
                var firstFind = randomCharacters.IndexOf(pattern);
                var lastFind = randomCharacters.LastIndexOf(pattern);

                if (firstFind > -1 && lastFind > -1 && pattern.Length > 0)
                {
                    randomCharacters = randomCharacters.Remove(lastFind, pattern.Length);
                    randomCharacters = randomCharacters.Remove(firstFind, pattern.Length);
                    messages.AppendLine("Shaked it.");

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                }
                else
                {
                    messages.AppendLine("No shake.");
                    break;
                }

            }

            Console.Write(messages.ToString());
            Console.WriteLine(randomCharacters);
        }
    }
}
