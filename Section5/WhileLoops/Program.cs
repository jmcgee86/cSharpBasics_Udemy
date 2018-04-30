using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // var i = 0;

            // while (i<=10)
            // {
            //     if (i % 2 ==0)
            //     {
            //         System.Console.WriteLine(i);
            //     }
            //    i++; 
            // }

            while(true)
            {
                System.Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;

            }
        }
    }
}
