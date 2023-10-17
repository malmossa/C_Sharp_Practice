
using System.Net.Http.Headers;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            Vehicle[] vehicles = { car, bicycle};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadLine();

        }

        class Vehicle
        {
            internal virtual void Go() { }
        }

        class Car : Vehicle 
        {
            internal override void Go()
            {
                Console.WriteLine("The car is moving!");
            }

        }

        class Bicycle : Vehicle 
        {
            internal override void Go()
            {
                Console.WriteLine("The bicycle is moving!");
            }
        }
                 
    }

}






