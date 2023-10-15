
using System.Net.Http.Headers;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                 
            // declare the array and add objects in one step
            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

            foreach(Car car in garage)
            {
                Console.WriteLine(car.model);
            }


            Console.ReadLine();

        }

        class Car
        {
            internal string model;

            internal Car(string model)
            {
                this.model = model;
            }
        }
                 
    }

}






