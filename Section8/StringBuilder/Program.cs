using System;
using System.Text;

namespace StringBuilder_Section8
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");
            
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);
            
            builder.Replace('-', '+');

            builder.Remove(0,10);

            builder.Insert(0, new string('-', 10));
          
            System.Console.WriteLine(builder);

            System.Console.WriteLine("First char: " + builder[0]);

        }
    }
}
