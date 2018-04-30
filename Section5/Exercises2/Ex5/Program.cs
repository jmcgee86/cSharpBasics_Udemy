using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a series of numbers seperate by a comma: ");
            var input = Console.ReadLine();
            var inputArray = input.Split(',');
            var largest = int.Parse(inputArray[0]);

            foreach (var number in inputArray)
            {
                //int.Parse(number);
                if(int.Parse(number) > largest){
                    largest = int.Parse(number);
                }
            }

            System.Console.WriteLine(largest);

        }
    }
}
