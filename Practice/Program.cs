
using System.Threading.Channels;

namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
                    
            // receive int and output string
            Func<int, string> receiveIntReturnsString;

            string GetNameOfTheMonth(int month)
            {
                DateTime date = new DateTime(2023, month, 1);
                return date.ToString("MMMM");
            }

            receiveIntReturnsString = GetNameOfTheMonth;

            string february = receiveIntReturnsString(2);
            Console.WriteLine(february);


            Console.ReadLine();

    }
   
  }
 
}
