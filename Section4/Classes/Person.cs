using System;

namespace CSharpFundamentals
{
    public class Person
    

    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            System.Console.WriteLine("My Name is " + FirstName + " " + LastName);
        }
    }
}