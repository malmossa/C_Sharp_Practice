using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Step 1: Deferred execution
            var evenNumbers = numbers.Where(n =>
            {
                Console.WriteLine($"Evaluating if {n} is even");
                return n % 2 == 0;
            });




            Console.ReadLine();
        }
    }
}





