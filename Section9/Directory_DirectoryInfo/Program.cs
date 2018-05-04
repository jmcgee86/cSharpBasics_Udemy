using System;
using System.IO;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:/temp/folder1");
            var files = Directory.GetFiles(@"c:\projects", "*.*", SearchOption.AllDirectories);
            foreach(var file in files)
                System.Console.WriteLine(file);

           var directories = Directory.GetDirectories(@"c:\projects", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
                System.Console.WriteLine(directory);

            Directory.Exists("...path");

            var directoryInfo = new DirectoryInfo("...path");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
