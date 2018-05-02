using System;

namespace String_Section8
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Jim McGee ";
            System.Console.WriteLine("Trim: '{0}'", fullName.Trim());
            System.Console.WriteLine("To Upper: '{0}'", fullName.Trim().ToUpper());
            var index = fullName.IndexOf(" ");
            var firstName = fullName.Substring(0,index);
            var lastName = fullName.Substring(index+1);
            System.Console.WriteLine("First Name: " + firstName);
            System.Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            System.Console.WriteLine("First Name: " + names[0]);
            System.Console.WriteLine("Last Name: " + names[1]);

            System.Console.WriteLine(fullName.Replace("Jim", "James"));
            //fullName.Replace('M', 'm');

            if (String.IsNullOrWhiteSpace(" "))
            System.Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            System.Console.WriteLine(age);

            float price = 29.95f;
            System.Console.WriteLine(price.ToString("C0"));

        }
    }
}
