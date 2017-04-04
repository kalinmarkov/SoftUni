using System;

class RandomizeWords
{
    static void Main()
    {
        var arrayOfWords = Console.ReadLine().Split();

        var rnd = new Random();

        for (int firstPosition = 0; firstPosition < arrayOfWords.Length; firstPosition++)
        {
            var secondPosition = rnd.Next(arrayOfWords.Length);
            var temp = arrayOfWords[secondPosition];
            arrayOfWords[secondPosition] = arrayOfWords[firstPosition];
            arrayOfWords[firstPosition] = temp;
        }

        Console.WriteLine(string.Join("\r\n", arrayOfWords));
    }
}