using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IncreasingCrisis
{
    static void Main()
    {
        // 60/100

        int n = int.Parse(Console.ReadLine());

        var listOfNumbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int mostRightElement = 0;
            int index = 0;
            bool isBreak = false;

            if (i == 0)
            {                
                listOfNumbers.AddRange(input);                
            }
            else
            {
                for (int j = 0; j < input.Count; j++)
                {
                    for (int k = 0; k < listOfNumbers.Count; k++)
                    {
                        if (input[j] > listOfNumbers[k])
                        {
                            mostRightElement = listOfNumbers[k];
                            index = listOfNumbers.IndexOf(mostRightElement);
                        }
                        else if (input[j] == listOfNumbers[k])
                        {
                            index++;
                        }
                    }
                    break;
                }

                listOfNumbers.InsertRange(index + 1, input);
            }

            int breakElement = 0;
            int breakPostion = 0;

            for (int j = 1; j < listOfNumbers.Count; j++)
            {
                if (listOfNumbers[j] < listOfNumbers[j - 1])
                {
                    breakElement = listOfNumbers[j];
                    breakPostion = listOfNumbers.LastIndexOf(breakElement);
                    isBreak = true;
                    break;
                }
            }

            if (isBreak)
            {
                for (int j = listOfNumbers.Count - 1; j >= breakPostion; j--)
                {
                    listOfNumbers.RemoveAt(j);
                }
            }
        }

        Console.WriteLine(string.Join(" ", listOfNumbers));

    }
}

