
namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle();
           
          
            Console.ReadLine();

        }

        abstract class Vehicle
        {
            internal int speed = 0;

            internal void go()
            {
                Console.WriteLine("This vehicle is moving!");
            }
        }
                 
    }

}






