using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            //write a program and ask the user to enter a number
            //compute the factorial of the number and print to console
            //example: if user enters 5, should calculate 5x4x3x2x1
            //and display it as 5! = 120
            
            int factorial = 1;
            Console.WriteLine("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());
            int originalInput = input;
            while (input >=1)
            {
                factorial *= input;
                input --;
            }

            System.Console.WriteLine(originalInput + "! = " + factorial);

        }
    }
}
