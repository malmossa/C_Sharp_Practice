using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      car car1 = new car();

      Console.WriteLine(car1.brand);
      Console.WriteLine(car1.modelName);
      car1.honk();

    }

  }


  // Base class (Parent)
  class Vehicle
  {
    public string brand = "Ford";
    public void honk()
    {
      Console.WriteLine("Tuut, Tuut!");
    }
  }

  // Derived class (Child)
  class car : Vehicle
  {
    public string modelName = "Mustang";
  }


}
