using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program and continuously ask the user to enter a number or "ok" to exit
            //Calculate the sum of all the previously entered numbers and display it on the console.
        
            int total = 0;

     

           // int num = int.Parse(Console.ReadLine());
        
        while(true)
            {
                Console.WriteLine("Enter a number or 'ok' to exit");
                var input = Console.ReadLine();

                if(input != "ok")
                {
                    total +=int.Parse(input);
                    continue;
                }
                System.Console.WriteLine(total);
                break;
            }

        }
    }
}
