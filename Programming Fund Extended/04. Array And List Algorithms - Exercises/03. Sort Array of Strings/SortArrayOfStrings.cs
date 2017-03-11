using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayOfStrings
{
    static void Main()
    {
        var arr = Console.ReadLine().Split().ToArray();

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                var firstElement = arr[i];
                var secondElement = arr[j];
                var firstIsSmaller = firstElement.CompareTo(secondElement) == -1 ? true : false;
                if (!firstIsSmaller)
                {
                    arr[i] = secondElement;
                    arr[j] = firstElement;
                }
            }
        }

        Console.WriteLine(string.Join(" ", arr));
    
    }
}

