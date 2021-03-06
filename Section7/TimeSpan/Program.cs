﻿using System;

namespace TimeSpan_section7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var timeSpan = new TimeSpan(1,2,3);
            
            var timeSpan1 = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duaration = end - start;
            System.Console.WriteLine("Duration: " + duaration);

            //Properties
            System.Console.WriteLine("Minutes: " + timeSpan.Minutes);
            System.Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add
            System.Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            System.Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            System.Console.WriteLine("ToString: " + timeSpan.ToString());

            //Parse
            System.Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
