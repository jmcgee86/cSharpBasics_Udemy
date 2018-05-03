using System;

namespace Ex2_Section8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few numbers separated by a hyphen. 
            //If the user simply presses Enter, without supplying an input, exit immediately; 
            //otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
            Console.WriteLine("Please enter a few numbers seperated by a hyphen or enter to escape: ");
            var inputString = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(inputString))
            {
                return;
            }
            else
            {

                var inputArray = inputString.Split('-');
                var found = 0;

                for(var i = 0; i<inputArray.Length - 1; i++)
                {
                    found = 0;
                    for (var j =0; j<inputArray.Length; j++)
                    {
                        if (inputArray[i] == inputArray[j])
                        {
                            found++;
                            if (found>1)
                            {
                                System.Console.WriteLine("Duplicate");
                                return;
                            }
                        }
                    }
                }
            }
            System.Console.WriteLine("No duplicates found");

        }
    }
}
