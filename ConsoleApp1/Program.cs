using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum1 = PlusMethod(8, 5);
      double myNum2 = PlusMethod(4.3, 6.26);

      Console.WriteLine("Int " + myNum1);
      Console.WriteLine("Double " + myNum2);
    }

    static int PlusMethod(int x, int y)
    {
      return x + y;
    }

    static double PlusMethod(double x, double y)
    {
      return x + y;
    }

  }
}
