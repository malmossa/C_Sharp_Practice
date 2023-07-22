

namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Year = 2022;

            Car car2 = new Car();
            car2.Brand = "Honda";
            car2.Year = 1999;


            Console.WriteLine($"First car: {car1.Brand}, {car1.Year}");
            Console.WriteLine($"Second car: {car2.Brand}, {car2.Year}");
            


            Console.ReadLine();

        }
   
  }
 
}
