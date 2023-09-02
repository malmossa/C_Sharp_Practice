using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            //bool boolFromString = bool.Parse("true");
            //Console.WriteLine($"Data type: {boolFromString.GetType()}");

            //int intFromString = int.Parse("100");
            //Console.WriteLine($"Data type: {intFromString.GetType()}");

            //double doubleFromString = double.Parse("1.234");
            //Console.WriteLine($"Data type: {doubleFromString.GetType()}");

            //string stringValue = doubleFromString.ToString();
            //Console.WriteLine($"Data type: {stringValue.GetType()}");

            ///* Explicit convertion, becuse we are going to lose some data
            // * like converting double to interger, we lose all decimal values*/

            //double doubleNumber = 12.345;
            //Console.WriteLine($"Integer: {(int)doubleNumber}");

            ///* Implicit convertion, when the smallest type is been converted
            // * into a larger type, so no data is been lost */
            //int intNumber = 10;
            //Console.WriteLine($"Double: {(double)intNumber}");

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt)); // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt)); // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble)); // convert double to int
            Console.WriteLine(Convert.ToString(myBool)); // convert bool to string
















            Console.ReadLine();
        }
    }
}