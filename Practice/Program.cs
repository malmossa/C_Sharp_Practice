
using System.Threading.Channels;

namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {

            int Sum(int a, int b)
            {
                return a + b;
            }
            
            // with lambda expression
            int Sum2 (int a, int b) => a + b;




            Sum(1, 1);
            Sum2(1, 1);

            Console.ReadLine();

    }
   
  }
 
}
