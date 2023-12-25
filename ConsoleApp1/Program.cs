using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
    }



  }

  class Car
  {
    public string color = "red";
  }


}
