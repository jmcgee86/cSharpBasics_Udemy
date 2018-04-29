using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte b = 1;
            // int i = b;
            // System.Console.WriteLine(i);

            //results in data loss
                // int i = 1000;
                // byte b = (byte)i;
                // System.Console.WriteLine(b);
            
            //successfully converts to in
                // string number = "1234";
                // int i = Convert.ToInt32(number);
                // System.Console.WriteLine(i);
            
            //need to handle error exception
                // try
                // {
                //     var number = "1234";
                //     byte b = Convert.ToByte(number);
                //     System.Console.WriteLine(b);
                // }
                // catch(Exception)
                // {
                //     System.Console.WriteLine("The number could not be converted to a byte");
                // }
                try
                {
                    string str = "true";
                    bool b = Convert.ToBoolean(str);
                    System.Console.WriteLine(b); 
                }
                catch(Exception)
                {
                    System.Console.WriteLine("The number could not be converted to a byte");
                }
                




        }
    }
}
