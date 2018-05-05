using System;
using System.IO;

namespace Ex1_Section9
{
    class Program
    {
        //Write a program that reads a text file and displays the number of words.
        //Write a program that reads a text file and displays the longest word in the file.
        static void Main(string[] args)
        {
            var path = @"/Users/jmcgee/Documents/cSharpBasics_Udemy/Section9/Exercises/Ex1/test.txt";
            var file = File.ReadAllText(path);
            System.Console.WriteLine(CountWords(file));
            System.Console.WriteLine(LongestWord(file));
        }

        static int CountWords(string file)
        {
            var wordsString = file.Replace("\n", " ");
            var wordsArray = wordsString.Split(" ");
            var wordCount = wordsArray.Length;

            return wordCount;
        }

        static string LongestWord(string file)
        {
            var removePunctuation = file.Replace(".", "");
            var wordsString = removePunctuation.Replace("\n", " ");
            
            var wordsArray = wordsString.Split(" ");
            var longLength = 0;
            string longWord = "longest";

            foreach (var word in wordsArray)
            {
                if (word.Length>longLength)
                {
                    longLength = word.Length;
                    longWord =  word;
                }
            }
            return longWord;
        }
    }
}
