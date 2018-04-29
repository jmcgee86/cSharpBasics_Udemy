using System;

namespace IfElseSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // int hour = 10;

            // if(hour > 0 && hour < 12)
            // {
            //     System.Console.WriteLine("It's morning.");
            // }
            // else if(hour >= 12 && hour < 18)
            // {
            //     System.Console.WriteLine("It's afternoon");
            // }
            // else
            // {
            //     System.Console.WriteLine("It's evening");
            // }
            
            //bool isGoldCustomer = true;
            // float price;
            // if(isGoldCustomer)
            // {
            //     price = 19.95f;
            // }
            // else
            // {
            //     price = 29.95f;
            // }

            // float price = (isGoldCustomer) ? 19.95f : 29.95f;
            // System.Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    System.Console.WriteLine("We have a promotion");
                    break;
                default:
                    System.Console.WriteLine("I don't know what season it is");
                    break;
            }



        }
    }
}
