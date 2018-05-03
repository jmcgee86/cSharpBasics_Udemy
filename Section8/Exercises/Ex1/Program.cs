using System;

namespace Ex1_Section8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few numbers separated by a hyphen. 
            //Work out if the numbers are consecutive. 
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; 
            //otherwise, display "Not Consecutive".
            
            Console.WriteLine("Please enter a few numbers seperated by a hyphen: ");
            var inputString = Console.ReadLine();
            var inputArray = inputString.Split('-');
            for(var i = 0; i<inputArray.Length - 1; i++)
            {
                var check = int.Parse(inputArray[i]);
                if (check - 1 != int.Parse(inputArray[i+1]) && check + 1 !=int.Parse(inputArray[i+1]))
                {
                    System.Console.WriteLine("Not Consecutive");
                    return;
                }

            }
            System.Console.WriteLine("Consecutive");
        }
    }
}
