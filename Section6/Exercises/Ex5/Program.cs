using System;
using System.Collections.Generic;


namespace Ex5_Section6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray;
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    inputArray = input.Split(',');
                    if (inputArray.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            foreach (var n in inputArray){
                numbers.Add(int.Parse(n));
            }
            numbers.Sort();

            for (var i = 0; i<3; i++)
            System.Console.WriteLine(numbers[i]);

        }
    }
}
