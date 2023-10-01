using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Mansor";

            Console.WriteLine(myObj.Name);

            Console.ReadLine();
        }

    }


    class Person
    {
        private string name; // field

        public string Name // property
        {
            get { return name; } // get method
            set { name = value; } // set method

        }
    }
 
}





