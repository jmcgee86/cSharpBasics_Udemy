using System;
using System.Collections.Generic;

namespace SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really long text";
            var summary = StringUtility.SummarizeText(sentence, 25);
            System.Console.WriteLine(summary);


        }
        // static string SummarizeText(string text, int maxLength = 20)
        // {
        //     if (text.Length < maxLength)
        //     {
        //         //System.Console.WriteLine(text);
        //         return text;
        //     }
            
        //         //sentence.Substring(0, maxLength)
        //         var words = text.Split(' ');
        //         var totalCharacters = 0;
        //         var summaryWords = new List <string>();

        //         foreach(var word in words)
        //         {
        //             summaryWords.Add(word);
        //             totalCharacters += word.Length + 1;
        //             if (totalCharacters > maxLength)
        //                 break;
        //         }

        //        var summary =  String.Join(" ", summaryWords) + "...";
        //        //System.Console.WriteLine(summary);
        //        return summary;
            
        // }
    }



}
