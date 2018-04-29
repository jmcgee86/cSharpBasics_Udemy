using System;

namespace Section4_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Jim"; //same as below
            var firstName = "Jim";
            var lastName = "McGee";
            //var fullName = firstName + " " + lastName;
            var fullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3]{"John", "Jack", "Mary"};
            var formattedNames = string.Join(",", names);
            //System.Console.WriteLine(formattedNames);

            //var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            //verbatim string:
            var text = @"Hi John
            Look into the following paths
            c:\\folder1\folder2
            c:\folder3\folder4";

            System.Console.WriteLine(text);

        }
    }
}
