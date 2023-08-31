using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            double myNum = 4.123456789012345; 
            Console.WriteLine(myNum);

            // Boolean, true or false
            bool canIvote = true;

            // String


            // Integer, whole number
            Console.WriteLine($"Integer range from: {int.MinValue} To {int.MaxValue}");
                
            // Long 
            Console.WriteLine($"Long range from: {long.MinValue} To {long.MaxValue}");

            // Decimal are more precision
            Console.WriteLine($"Decimal range from: {decimal.MinValue} To {decimal.MaxValue}");

            // Double, floating point number
            Console.WriteLine($"Double range from: {double.MinValue} To {double.MaxValue}");

            // Float
            Console.WriteLine($"Float range from: {float.MinValue} To {float.MaxValue}");




            /* Decimal is more precision, 28 digits after the period.
               use commonly with money, add "M" at the end */
            decimal decimalNumber = 3.1234567890123456789012345678M; 

            /* Double is the most common use, precision 15 digits after the period*/
            double doubleNumber = 3.144780093260476;

            /* Float precision is 7 digits after the period, add "F" at the end*/
            float floatNumber = 3.14478009326047620529F;



            Console.WriteLine(canIvote);
            Console.WriteLine(decimalNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(floatNumber);


            Console.ReadLine();
        }
    }
}