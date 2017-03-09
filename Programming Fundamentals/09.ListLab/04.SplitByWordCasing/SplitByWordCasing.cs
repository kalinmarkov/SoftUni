using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var lower = new List<string>();
            var upper = new List<string>();
            var mixed = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                bool isLower = false;
                bool isUpper = false;
                bool isMixed = false;

                for (int j = 0; j < words[i].Length; j++)
                {
                    if (words[i][j] >= 'a' && words[i][j] <= 'z')
                    {
                        if (isUpper)
                        {
                            isLower = false;
                            isUpper = false;
                            isMixed = true;
                            break;
                        }
                        isLower = true;
                    }
                    else if (words[i][j] >= 'A' && words[i][j] <= 'Z')
                    {
                        if (isLower)
                        {
                            isLower = false;
                            isUpper = false;
                            isMixed = true;
                            break;
                        }
                            isUpper = true;
                    }
                    else
                    {
                        isLower = false;
                        isUpper = false;
                        isMixed = true;
                        break;
                    }
                }

                if (isLower)
                {
                    lower.Add(words[i]);
                }
                else if (isUpper)
                {
                    upper.Add(words[i]);
                }
                else if (isMixed)
                {
                    mixed.Add(words[i]);
                }

            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lower));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixed));
            Console.WriteLine("Upper-case: " + string.Join(", ", upper));
        }
    }
}
