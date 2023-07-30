
namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
            int counter = 0;

            do 
            {
                Console.WriteLine(counter);
                counter++; 

                if(counter == 5)
                {
                    break;
                }
            } while (counter < 10);



            Console.ReadLine();

    }

    
   
  }
 
}
