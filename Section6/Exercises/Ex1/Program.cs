using System;
using System.Collections.Generic;


namespace Ex1_Section6
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            while(true)
            {
                System.Console.Write("Enter a name or press enter to escape: ");
                var input = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input))
                {
                   names.Add(input);
                   continue;
                }
                if (names.Count == 1 )
                {
                   System.Console.WriteLine(names[0] + " Likes your post");
                }
                else if(names.Count == 2)
                {
                    System.Console.WriteLine(names[0] + " and " + names[1] + " like your post");
                }
                else if(names.Count > 2)
                {
                    System.Console.WriteLine(names[0] + " and " + names[1] + " and " + (names.Count - 2) + " others like your post");
                }
               break;
            }

            
        }
    }
}
