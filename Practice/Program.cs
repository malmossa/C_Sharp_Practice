using System;


namespace Practice
{
    public class Program
    {
        static void Main(string[] arge)
        {
            /* Homework: Create a Console Application 
               that has variables to hold a person's name, age,
               if they are alive, and their phone number. */

            string name = "Mansor";
            string phoneNumber = "62662942255";
            int age = 50;
            bool isAlive = true;

            Console.WriteLine($"Name: {name}.");
            Console.WriteLine($"Age: {age}.");
            Console.WriteLine($"Phone: {phoneNumber}.");
            Console.WriteLine($"Is he alive: {isAlive}.");


            Console.ReadLine();
        }
    }
    }