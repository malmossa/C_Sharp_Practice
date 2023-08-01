
namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
            for (int i = 0; i < 100; i++) 
            {
                if (i == 10)
                {
                    goto LoopEscape;
                }

                Console.WriteLine(i);
            }

            LoopEscape:
            Console.WriteLine("Loop is Escaped!");



            Console.ReadLine();

    }

    
   
  }
 
}
