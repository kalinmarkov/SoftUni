using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var text = "Test Pesho Gosho Ivan Cat Dog";

        var bannedWords = new string[]
        {
            "Test",
            "Cat"
        };

        foreach (var word in bannedWords)
        {
            text = text.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(text);
    }
}

