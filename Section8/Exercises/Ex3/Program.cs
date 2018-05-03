using System;

namespace Ex3_Section8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
            //A valid time should be between 00:00 and 23:59. 
            //If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
            //If the user doesn't provide any values, consider it as invalid time. 

            System.Console.WriteLine("Please enter a valid time in 24-hour format: ");
            var input = Console.ReadLine();

            if (input.Length < 5 || input.IndexOf(':')!=2)
            {
                System.Console.WriteLine("Invalid Time");
                return;
            }
            else
            {
                var nums = input.Split(':');
                if(int.Parse(nums[0]) < 0 || int.Parse(nums[0]) > 23 ||int.Parse(nums[1]) < 0 || int.Parse(nums[1]) > 59 )
                {
                    System.Console.WriteLine("Invalid Time");
                    return;
                }
                else
                {
                    System.Console.WriteLine("Ok");
                }
            }
        }
    }
}
