using System;


namespace Practice
{
    public class Program
    {
        static void Main(string[] arge)
        {

            // Implcit convertion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;

            // Explicit convertion
            // Cast double to int
            myInt = (int)myDouble;

            // Type Convertion
            string myString = myDouble.ToString(); // "13.37"

            Console.WriteLine(myInt);



            Console.ReadLine();
        }
    }
}