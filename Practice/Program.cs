using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {

            int num1 = AddTwoNumbers(5, 5);
            double num2 = AddTwoNumbers(1.99, 1.99);

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            Console.ReadLine();
        }

       
        static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        static double AddTwoNumbers(double x, double y)
        {
            return x + y;
        }
    }
}





