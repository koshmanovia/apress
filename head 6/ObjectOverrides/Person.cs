using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public Person(string fName, string IName, int personAge) 
        {
            FirstName = fName;
            LastName = IName;
            Age = personAge;
        }            
        public Person() { }
    }
}
