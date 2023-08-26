using System;


namespace Practice
{
    public class Program
    {
        static void Main(string[] arge)
        {
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            switch(firstName.ToLower())
            {
                case "mansor":
                    Console.WriteLine("Hello, Mansor");
                    break;
                case "nujood":
                    Console.WriteLine("Hello, Nujood");
                    break;
                default:
                    Console.WriteLine("Hello, there!");
                    break;
            }





            
            Console.ReadLine();
        }
    }
    }