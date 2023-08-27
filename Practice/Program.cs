using System;


namespace Practice
{
    public class Program
    {
        static void Main(string[] arge)
        {
            Console.Write("What is your age? ");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);

            if(isValidAge == true)
            {
                age += 10;
                Console.WriteLine($"You are going to be {age} years old in 10 years. ");
            } else
            {
                Console.WriteLine("That was not a valid age!");
            }

            Console.ReadLine();
        }
    }
    }