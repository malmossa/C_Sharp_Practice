using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class User
    {
        internal string _firstName;
        internal string _lastName;
        internal int _age;

        internal User(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        internal bool IsRetired()
        {
            return (_age >= 60);
        }
    }
}
