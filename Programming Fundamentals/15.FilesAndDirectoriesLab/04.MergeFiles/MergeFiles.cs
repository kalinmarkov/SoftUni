using System;
using System.IO;

namespace _04.MergeFiles
{
    class MergeFiles
    {
        static void Main()
        {
            var firstFile = File.ReadAllLines("FileOne.txt");
            var secondFile = File.ReadAllLines("FileTwo.txt");

            File.WriteAllText("result.txt", string.Empty);

            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText("result.txt", firstFile[i] + Environment.NewLine + secondFile[i] + Environment.NewLine);
            }
        }
    }
}
