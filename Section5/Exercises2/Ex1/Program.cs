﻿using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            //Display the count on the console.
            int counter = 0;

            for (var i = 1; i<=100; i++)
            {
                if (i%3 == 0)
                {
                    counter++;
                }
            }
            System.Console.WriteLine(counter);
        }
    }
}
