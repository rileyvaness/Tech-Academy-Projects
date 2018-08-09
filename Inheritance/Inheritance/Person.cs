using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //#1 class named Person with two properties: FirstName and LastName.
    class Person
    {

        public string FirstName;
        public string LastName;
     //#2 void method of sayName()
        public void sayName ()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
