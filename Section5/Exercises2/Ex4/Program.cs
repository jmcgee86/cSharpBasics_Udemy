using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var chances = 0;

            var randomNumber = random.Next(1,10);
            System.Console.WriteLine("Secret number is: " + randomNumber);

            // System.Console.WriteLine("Try to guess the random number between 1 and 10");
            // var guess = int.Parse(Console.ReadLine());

            while(chances < 4)
            {
                System.Console.WriteLine("Try to guess the random number between 1 and 10");
                var guess = int.Parse(Console.ReadLine());
                if(guess == randomNumber)
                {
                    System.Console.WriteLine("You Won");
                    return;
                }
                else
                {
                    chances++;
                }
            }
            System.Console.WriteLine("You Lost");

        }
    }
}
