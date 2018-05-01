using System;
using System.Collections.Generic;

namespace Ex3_Section6
{
    class Program
    {
        //Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. 
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while(numbers.Count < 5)
            {
                System.Console.Write("Please enter a unique number: ");
                var numInput = int.Parse(Console.ReadLine()); 
                bool found = false;
                for(var i = 0; i<numbers.Count; i++)
                {
                    if (numInput == numbers[i])
                    {
                        System.Console.WriteLine("Error, number must be unique");
                        found = true;
                        break;
                    }
                }  
                if (found == false)
                {
                    numbers.Add(numInput);
                }   
                else
                {
                    found = false;
                }
            }
            numbers.Sort();
            foreach (var n in numbers)
            System.Console.WriteLine(n);
        }
    }
}
