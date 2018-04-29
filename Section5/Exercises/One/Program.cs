using System;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between one and ten");
            int num = int.Parse(Console.ReadLine());

            if(num < 1 || num > 10)
            {
                System.Console.WriteLine("Invalid");
            }
            else 
            {
                System.Console.WriteLine("Valid");
            }
        }
    }
}
