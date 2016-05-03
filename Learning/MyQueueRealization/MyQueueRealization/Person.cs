using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueRealization
{
    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstname, string lastname, int age)
        {
            Age = age;
            FirstName = firstname;
            LastName = lastname;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Surname: {1}, Age: {2}", FirstName, LastName, Age);
        }
    }
}
