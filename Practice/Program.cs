using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNumber = 123;
            long longNumber = 150_000_000_00;
            float floatNumber = 5.75f; // we add (f) at the end
            double doubleNumber = 19.99;
            decimal decimalNumber = 23.123456789000000000m; // we add (m) at the end
            bool isAlive = true;
            char myGrade = 'A';
            string greeting = "Hello world!";

            Console.WriteLine(intNumber);
            Console.WriteLine(longNumber);
            Console.WriteLine(floatNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(decimalNumber);
            Console.WriteLine(isAlive);
            Console.WriteLine(myGrade);
            Console.WriteLine(greeting);




            Console.ReadLine();
        }
    }
}





