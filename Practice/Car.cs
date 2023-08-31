using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Car
    {
        // Fields
        private string _brand;

        // Constructors

        internal Car() : this("default brand")
        {
            Console.WriteLine("Instantiating a car");
        }

        internal Car(string brand)
        {
            Console.WriteLine("Instantiating a car with a brand");
            _brand = brand;
        }

        internal string Brand
        {
            get
        }
    }
}
