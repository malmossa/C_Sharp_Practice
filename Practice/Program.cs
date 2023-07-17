
using System.Threading.Channels;

namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
            int num1 = 5;

            void Double(ref int n )
                {
                    n *= 2;
                    Console.WriteLine($"The value inside the method is " + n);
                }

            Console.WriteLine("The value outside of the method is " + num1);
            Double(ref num1);
            Console.WriteLine("The value outside of the method is " + num1);



            Console.ReadLine();

    }
   
  }
 
}
