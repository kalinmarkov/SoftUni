using System;
using System.IO;
using System.Linq;

namespace _05.FolderSize
{
    class FolderSize
    {
        static void Main()
        {
            //! ! !  TestFolder need to be added in .\Debug  ! ! !

            var currentFiles = Directory.GetFiles("TestFolder");
            var totalLenght = 0L;

            foreach (var file in currentFiles)
            {
                var fileInfo = new FileInfo(file);
                totalLenght += fileInfo.Length;
            }

            Console.WriteLine(totalLenght / 1024.0 / 1024.0);

            // Solution with LINQ

            //var totalLenght = Directory
            //    .GetFiles("TestFolder")
            //    .Select(f => new FileInfo(f))
            //    .Sum(f => f.Length / 1024.0 / 1024.0);

            //Console.WriteLine(totalLenght);
        }
    }
}
