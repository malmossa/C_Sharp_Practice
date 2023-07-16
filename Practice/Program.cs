
namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
            double total1 = Checkout(3.99, 5.75, 15);
            double total2 = Checkout(3.99, 5.75);
            double total3 = Checkout(3.99, 5.75, 1.99, 100);

            Console.WriteLine(total1);
            Console.WriteLine(total2);
            Console.WriteLine(total3);

            Console.ReadLine();

    }

    static double Checkout(params double[] prices)
    {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
    }
  }
 
}
