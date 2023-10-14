using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bigList();
                       
            Console.ReadLine();
        }
       
        static void bigList()
        {
            List<string> names = Enumerable.Repeat("mansor", 10).ToList();

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
           
    }


    
}






