using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var text = Console.ReadLine().ToLower();
        var pattern = Console.ReadLine().ToLower();

        int index = 0;
        int found = 0;
        int count = 0;

        while (true)
        {
            found = text.IndexOf(pattern, index);
            if (found >= 0)
            {
                index = found + 1;
                count++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(count);

        
    }
}

