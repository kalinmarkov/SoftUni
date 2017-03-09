using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayModifier
{
    static void Main()
    {
        var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        while (true)
        {
            var command = Console.ReadLine().Split();
            if (command[0] == "end")
            {
                break;
            }
            else if (command[0] == "swap")
            {
                SwapArrElements(arr, command);
            }
            else if (command[0] == "multiply")
            {
                MultiplyArrElements(arr, command);
            }
            else if (command[0] == "decrease")
            {
                DecreaceArrElements(arr);
            }
        }

        Console.WriteLine(string.Join(" ", arr));
    }

    private static void DecreaceArrElements(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i]--;
        }
    }

    private static void MultiplyArrElements(int[] arr, string[] command)
    {
        int index1 = int.Parse(command[1]);
        int index2 = int.Parse(command[2]);
        arr[index1] = arr[index1] * arr[index2];
    }

    private static void SwapArrElements(int[] arr, string[] command)
    {
        int index1 = int.Parse(command[1]);
        int index2 = int.Parse(command[2]);
        var oldValue = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = oldValue;
    }
}

