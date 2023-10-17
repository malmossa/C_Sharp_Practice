using System;
using System.Threading;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000); // it will delay for 1 second.
            }

            Console.ReadLine();
        }        
    }
}






