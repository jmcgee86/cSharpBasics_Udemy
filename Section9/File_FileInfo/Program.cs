﻿using System;
using System.IO;

namespace File_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", "newfile.jpg", true);
            File.Delete(path);
            if(File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...string");
            fileInfo.Delete();
           if(fileInfo.Exists)
           {
               //
           }
        }
    }
}
