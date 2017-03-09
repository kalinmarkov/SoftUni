using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnunionLists
{
    static void Main()
    {
        var primalNums = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var arrOfNums = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();


            for (int j = 0; j < arrOfNums.Count; j++)
            {
                if (primalNums.Contains(arrOfNums[j]))
                {
                    primalNums.Remove(arrOfNums[j]);
                }
                else
                {
                    primalNums.Add(arrOfNums[j]);
                }
            }
            
        }

        primalNums.Sort();

        Console.WriteLine(string.Join(" ", primalNums));
    }
}

