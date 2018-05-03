using System;

namespace Ex5_Section8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter an English word. 
            //Count the number of vowels (a, e, o, u, i) in the word. 
            //So, if the user enters "inadequate", the program should display 6 on the console.

            System.Console.WriteLine("enter a word: ");
            var input = Console.ReadLine();
            var counter = 0;

            for(var i = 0; i<input.Length; i++)
            {
                if (input[i] =='a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                counter++;
            }

            System.Console.WriteLine(counter);

        }
    }
}
