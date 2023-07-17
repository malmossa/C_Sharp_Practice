
using System.Threading.Channels;

namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {

            Tuple<int, string> tuple1 = new Tuple<int, string>( 99, "Mansor");
            Tuple<int, string, int> tuple2 = new Tuple<int, string, int>(50, "Mansor", 21);

            // OR

            var tuple3 = (1, 2, "Almossa");


            Console.WriteLine(tuple1.Item1);
            Console.WriteLine(tuple2.Item2);
            Console.WriteLine(tuple3.Item3);



            Console.ReadLine();

    }
   
  }
 
}
