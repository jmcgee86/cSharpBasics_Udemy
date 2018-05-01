using System;

namespace Ex2_Section6
{
    class Program
    {

        //Write a program and ask the user to enter their name. 
        //Use an array to reverse the name and then store the result in a new string. 
        //Display the reversed name on the console.
        static void Main(string[] args)
        {
            System.Console.Write("Please enter your name: ");
            var nameString = Console.ReadLine();

            char[] nameArray = nameString.ToCharArray();

            Array.Reverse(nameArray);

            var reversedName = string.Join("",nameArray);

            System.Console.WriteLine(reversedName);

            // foreach(var c in nameArray)
            // {
            //     System.Console.WriteLine(c);
            // }

        }
    }
}
