using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int result;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

            } catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers please!");
            } catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero! IDIOT!!");
            } catch (Exception e) // catch anyting else
            {
                Console.WriteLine("Something went wrong!");
            } finally 
            {
                Console.WriteLine("Thanks for visiting!");
            }
            

            Console.ReadLine();
        }

              
    }
}






