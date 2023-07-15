
namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
            
           void PrintOnTheConsole(string message = "Hey", int times = 3)
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine(message);
                }
            }

            PrintOnTheConsole();

            Console.ReadLine();

    }
  }
 
}
