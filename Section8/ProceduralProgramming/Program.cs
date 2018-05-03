using System;

namespace ProceduralProgramming_Section8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What's your name?");
            var name = Console.ReadLine();

            var reversed = ReversedName(name);

            System.Console.WriteLine("Reversed name: " + reversed);
        }

        public static string ReversedName (string name)
        {
            var array = new char[ name.Length ];
            for(var i = name.Length; i > 0; i--)
                array[ name.Length - i ] = name[ i - 1 ];
            
            //var reversed = new string (array);
            //return reversed;
            return new string (array);
        }
    }
}
