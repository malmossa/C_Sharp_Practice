
namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
            Random random = new Random();
            int randomNumber = random.Next();

            if(randomNumber % 2 == 0)
            {
                Console.WriteLine($"The random number {randomNumber} is even");
            } else
            {
                Console.WriteLine($"The random number {randomNumber} is odd");
            }



            Console.ReadLine();

    }
   
  }
 
}
