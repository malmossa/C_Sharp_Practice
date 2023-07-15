
namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
            // Method with return value
            string FirstName()
            {
                return "Mansor";
            }

            // Methods without a return value
            void LastName()
            {
                Console.WriteLine("Almossa");
            }

            string firstName = FirstName();

            Console.WriteLine(firstName);
            LastName();
            
            Console.ReadLine();

    }
  }
 
}
