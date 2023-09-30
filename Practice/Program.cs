using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);

            Console.WriteLine(Ford.model);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.year);


            Console.ReadLine();
        }

    }
 
}





