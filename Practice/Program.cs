using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.color = "Black";
            car1.maxSpeed = 100;

            Console.WriteLine(car1.color);
            Console.WriteLine(car1.maxSpeed);


            Console.ReadLine();
        }


    }
 
}





