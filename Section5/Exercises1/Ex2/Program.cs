using System;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another positive integer");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                System.Console.WriteLine(num1);
            }
            else if (num1 < num2) 
            {
                System.Console.WriteLine(num2);
            }
            else
            {
                System.Console.WriteLine("The numbers are equal");
            }
            
        }
    }
}
