using System;


namespace Practice
{
    public class Program
    {
        static void Main(string[] arge)
        {
            // Declaring a variable
            int num1;
            // Assigning a value to a variable
            num1 = 13;
            Console.WriteLine(num1);

            // Declaring and initializing a varible in one go
            int num2 = 23;
            Console.WriteLine(num2);

            //Declaring multiple varables at once
            int num3, num4, num5;
            num3 = 1;
            num4 = 2;
            num5 = 3;
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);

            // Double
            double d1 = 3.1415;
            double d2 = 5.1;
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            // Float
            float f1 = 3.1315f;
            float f2 = 5.1f;
            Console.WriteLine(f1);
            Console.WriteLine(f2);

            // String
            string name = "Mansor";
            Console.WriteLine(name);

            // Using string methods
            string upperCaseName = name.ToUpper();
            Console.WriteLine(upperCaseName);

            // Using concatination
            string message = "Hello there " + " my name is " + name;
            Console.WriteLine(message);




            Console.ReadLine();
        }
    }
}