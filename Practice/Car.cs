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
        private string? _brand;
        private int _year;

        // Properties
        internal string? Brand
        {
            get { return _brand!.ToUpper(); }
            set { _brand = value; }
        }

        // Auto-implemeted property
        internal int Year { get; set; } = 1990;
    }
}
