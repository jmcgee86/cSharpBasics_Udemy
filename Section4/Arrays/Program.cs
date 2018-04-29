using System;

namespace Section4_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] numbers = new int[3]; //same as below
            var numbers = new int[3];
            numbers[0] = 1;
            System.Console.WriteLine(numbers[0]);
            System.Console.WriteLine(numbers[1]);
            System.Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            System.Console.WriteLine(flags[0]);
            System.Console.WriteLine(flags[1]);
            System.Console.WriteLine(flags[2]);

            var names = new string[3] {"Jack", "John", "Mary"};

        }
    }
}
