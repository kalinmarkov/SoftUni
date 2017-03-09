
namespace exercise
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            var currentFiles = Directory.GetFiles("TestFolder");
            var totalLenght = 0L;

            foreach (var file in currentFiles)
            {
                var fileInfo = new FileInfo(file);
                totalLenght += fileInfo.Length;
            }

            Console.WriteLine(totalLenght / 1024.0 / 1024.0);
        }
    }
}