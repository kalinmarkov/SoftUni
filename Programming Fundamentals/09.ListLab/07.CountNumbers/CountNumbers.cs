using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();

            Dictionary<int, int> countNumbers = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!countNumbers.ContainsKey(numbers[i]))
                {
                    countNumbers.Add(numbers[i], 1);
                }
                else
                {
                    countNumbers[numbers[i]]++;
                }
            }

            foreach (var item in countNumbers)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
