using System;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      checkAge(20);
    }

    static void checkAge(int age)
    {
      if (age < 18)
      {
        throw new ArithmeticException("Access denied - You must be at least 18 years old.");
      }
      else
      {
        Console.WriteLine("Access granted - You are old enough!");
      }
    }

  }







}
