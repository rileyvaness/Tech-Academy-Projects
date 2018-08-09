using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //#3 Employee class inherit from Person class
    class Employee : Person
    {


        //#4 Implement the SayName() in the Employee class.
        public override void sayName(string FirstName, string LastName)
        {
            Console.WriteLine("The Employee's name is, {0} {1}.", FirstName, LastName);
            Console.ReadLine();
        }

    }
}
