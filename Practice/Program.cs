using System;
using System.Text.RegularExpressions;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // validating numbers input
            Console.Write("What is your age? ");
            string userInput = Console.ReadLine();
            bool isUserInputValid = int.TryParse(userInput, out int age);

            if(isUserInputValid )
            {
                Console.WriteLine($"Your age is {age}");
            } else
            {
                Console.WriteLine("Sorry, invalid input!");
            }








            Console.ReadLine();
        }
    }
}





