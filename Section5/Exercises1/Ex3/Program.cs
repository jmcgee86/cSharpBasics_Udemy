using System;

namespace Three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter image width");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter image height");
            int height = int.Parse(Console.ReadLine());

            if(width > height)
            {
                System.Console.WriteLine("Image is landscape");
            }
            else if (height < width) 
            {
                System.Console.WriteLine("Image is portrait");
            }
            else
            {
                System.Console.WriteLine("Image is square");
            }
            
        }
    }
}
