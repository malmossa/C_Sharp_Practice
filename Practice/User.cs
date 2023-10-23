using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class User
    {
        private string _firstName;
        private string _lastName;
        private int _age;

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
