using System;
using System.IO;

namespace Path_Section9
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\Projects\CSharp\HelloWorld\HelloWorld.sln";
           var dotIndex =  path.IndexOf('.');

           System.Console.WriteLine("Extension: " + Path.GetExtension(path));
           System.Console.WriteLine("File name: " + Path.GetFileName(path));
           System.Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
           System.Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
