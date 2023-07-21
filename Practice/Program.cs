
using System.Threading.Channels;

namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
            void Process(Action action)
            {
                Console.WriteLine("Before executing the method");
                action();
                Console.WriteLine("After executing the method");
            }

            Process(()=>
            {
                Console.WriteLine(DateTime.Now);
            });


            Console.ReadLine();

    }
   
  }
 
}
