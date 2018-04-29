using System;

namespace Section4_RefTypes_DataTypes
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // var a = 10;
            // var b = a;
            // b++;

            //System.Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            // var array1 = new int[3]{1,2,3};
            // var array2 = array1;
            // array2[0] = 0;
            // System.Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            var number = 1;
            Increment(number);
            System.Console.WriteLine(number);
            //number still equals 1 here because it is a value type, not reference type

            var person = new Person() {Age = 20};
            MakeOld(person);
            System.Console.WriteLine(person.Age);
            //person age is now 30 because it passes reference and not copy

        }

        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
