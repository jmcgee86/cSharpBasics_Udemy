using System;
using System.Collections.Generic;

namespace Ex4_Section6
{
    class Program
    {
        //Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
        //The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var input = "continue";
            var uniqueNums = new List<int>();
            while(true)
            {
                
                System.Console.Write("Please enter a number or quit to exit: ");
                input = Console.ReadLine();
                if (input == "Quit")
                    break;
                else
                {
                    var numInput = int.Parse(input);
                    bool found = false;
                    for(var i = 0; i<numbers.Count; i++)
                    {
                        if (numInput == numbers[i])
                        {
                            found = true;
                            break;
                        }
                    }  
                    numbers.Add(numInput);

                    if (found == false)
                    {
                        uniqueNums.Add(numInput);
                    }   
                    else
                    {
                        found = false;
                    }
            }
        }
            foreach (var n in uniqueNums)
            System.Console.WriteLine(n);
        }
    }

}
