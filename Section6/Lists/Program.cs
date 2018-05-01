﻿using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>(){ 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach(var number in numbers)
            {
                System.Console.WriteLine(number);
            }
            System.Console.WriteLine("IndexOf()");
            System.Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            System.Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            System.Console.WriteLine("Count: " + numbers.Count);

            //Remove()
            for(var i = 0; i<numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach(var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            //Clear()
            numbers.Clear();
            System.Console.WriteLine("Last Count: " + numbers.Count);

        }
    }
}
