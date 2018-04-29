using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Jim";
            bool isWorking = true;
            Console.WriteLine(number);
            System.Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);

            System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            const float Pi = 3.14f;
        }
    }
}
