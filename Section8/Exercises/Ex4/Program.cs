using System;
using System.Text;

namespace Ex4_Section8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few words separated by a space. 
            //Use the words to create a variable name with PascalCase. 
            //For example, if the user types: "number of students", display "NumberOfStudents". 
            //Make sure that the program is not dependent on the input. 
            //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            System.Console.WriteLine("Enter a few words seperated by a space: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            return;

            var pascalCaseVariable = "";
            var inputLower = input.ToLower();
            var splitInput = inputLower.Split(" ");

            foreach (var word in splitInput)
            {
                var changedWord = char.ToUpper(word[0]) + word.Substring(1);
                pascalCaseVariable = pascalCaseVariable + changedWord;
            }
            System.Console.WriteLine(pascalCaseVariable);
        }
    }
}
