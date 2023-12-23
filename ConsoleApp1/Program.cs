using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      DateTime date = DateTime.Now;

      DateTime tomorrow = date.AddDays(1);

      Console.WriteLine(tomorrow);

      // DateTime format
      Console.WriteLine(date.ToLongDateString());
      Console.WriteLine(date.ToShortDateString());
      Console.WriteLine(date.ToLongTimeString());
      Console.WriteLine(date.ToShortTimeString());

      // Custom DateTime format
      Console.WriteLine(date.ToString());
      Console.WriteLine(date.ToString("yy-MM-dd"));



    }
  }
}
