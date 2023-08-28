using System;


namespace Practice
{
    public class Program
    {
        static void Main(string[] arge)
        {
            string continueResult = string.Empty;

            do
            {
                Console.Write("What is your name? ");
                string name = Console.ReadLine();

                Console.WriteLine($"Hello {name}");

                Console.Write("Do you want to continue (yes/no): ");
                continueResult = Console.ReadLine();

            } while (continueResult.ToLower() == "yes");

            Console.ReadLine();
        }
    }
}