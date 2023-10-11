using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double customer1 = Checkout(3.99, 5.75, 1.5);
            double customer2 = Checkout(10.99, 6.50, 1.99, 10, 27.99);

            Console.WriteLine(customer1);
            Console.WriteLine(customer2);

            Console.ReadLine();
        }

        static double Checkout(params double[] prices)
        {
            double total = 0;

            foreach(double price in prices)
            {
                total += price;
            }
            return total;
        }
        
    }
}






