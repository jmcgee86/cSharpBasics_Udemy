using System;

namespace Four
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter speed limit");
            int speedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter speed of car");
            int carSpeed = int.Parse(Console.ReadLine());

            int points = 0;
            int difference = 0;

            if(speedLimit > carSpeed)
            {
                System.Console.WriteLine("Ok");
            }
            else
            {
                difference = carSpeed - speedLimit;
            }

            if (difference > 5 && difference%5 !=0)
                {
                    points = difference%5;
                }
            else
            {
                points = difference / 5;
            }

            if(points > 0 && points < 12)
            {
                System.Console.WriteLine("Demerit Points: {0}", points);
            }
            else if (points > 12)
            {
                System.Console.WriteLine("Demerit Points: {0}", points);
                System.Console.WriteLine("License Suspended");

            }
            
            
        }
    }
}
